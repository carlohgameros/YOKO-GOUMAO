using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using YOKO.enums;
using YOKO.Interfaces;
using YOKO.Models;

namespace YOKO.Helpers
{
    public class TicketsHelper
    {
        # region Logo
        private readonly int logoWidth = 300;
        # endregion

        private PrintDocument printDocument;
        private LegalData legalData;
        private List<ProductItem> products;
        private List<Service> services;
        private ITicketHelper listener;

        # region Ticket
        private int spacingHeight = 0;
        private bool isDisclaimerNeeded = false;

        private readonly int width = 800;
        private readonly int marginLeft = 50;
        private readonly int remision = 0;
        private readonly double total = 0.00f;
        #endregion

        public TicketsHelper(ITicketHelper listener, List<ProductItem> products, List<Service> services, int remision, double total)
        {
            this.listener = listener;
            this.products = products;
            this.services = services;
            this.remision = remision;
            this.total = total;
            this.isDisclaimerNeeded = services.Count > 0;

            legalData = new LegalData();
        }

        private void printPage(object sender, PrintPageEventArgs e)
        {
            AddHeader(e);
            AddClient(e);
            AddServices(e);
            AddProducts(e);
            AddDisclaimer(e);
            AddFooter(e);
        }

        private void AddServices(PrintPageEventArgs e)
        {
            if (services.Count > 0)
            {
                setDataIfExist(e, "", "SERVICIOS", true);

                getHeight((int)TicketElements.headerText);
                e.Graphics.DrawString("NOMBRE", Fonts.sanSerifbold, Brushes.Black, marginLeft, spacingHeight, near());
                e.Graphics.DrawString("IMPORTE", Fonts.sanSerifbold, Brushes.Black, width - marginLeft, spacingHeight + (int)TicketElements.headerText, far());
                getHeight((int)TicketElements.product);

                foreach (Service service in services)
                {
                    getHeight((int)TicketElements.normalSpacing);
                    e.Graphics.DrawString($"{service.description}", Fonts.sanSerifRegular, Brushes.Black, marginLeft, spacingHeight, near());
                    e.Graphics.DrawString($"${service.price}", Fonts.sanSerifRegular, Brushes.Black, width - marginLeft, spacingHeight + (int)TicketElements.headerText, far());

                    if (service.IsHairCut() && service.GetHairCutInformation != null)
                    {
                        HairCut hairCut = service.GetHairCutInformation;
                        setDataIfExist(e, "Tamaño de Navaja: ", hairCut.GetKnifeSize().ToString(), false);
                        setDataIfExist(e, "Especificaciones: ", hairCut.GetSpecifications(), false);
                    }

                    getHeight((int)TicketElements.normalSpacing);
                    drawSmallLine(e);
                }
            }
        }

        public void AddHeader(PrintPageEventArgs e)
        {
            Bitmap logo = new Bitmap(Properties.Resources.WhatsApp_Image_2019_03_09_at_13_50_01);

            ScaleImage(e, logo, logoWidth, logoWidth);

            getHeight(((int)TicketElements.headerText) * 5);

            e.Graphics.DrawString(legalData.name, Fonts.sanSerifRegular, Brushes.Black, width / 2, getHeight((int)TicketElements.headerText), centered());
            e.Graphics.DrawString($"{legalData.street} {legalData.postalCode}", Fonts.sanSerifRegular, Brushes.Black, width / 2, getHeight((int)TicketElements.headerText), centered());
            e.Graphics.DrawString(legalData.colonia, Fonts.sanSerifRegular, Brushes.Black, width / 2, getHeight((int)TicketElements.headerText), centered());
            e.Graphics.DrawString(legalData.state, Fonts.sanSerifRegular, Brushes.Black, width / 2, getHeight((int)TicketElements.headerText), centered());
            e.Graphics.DrawString($"RFC: {legalData.rfc}", Fonts.sanSerifRegular, Brushes.Black, width / 2, getHeight((int)TicketElements.headerText), centered());
            e.Graphics.DrawString(legalData.phone, Fonts.sanSerifRegular, Brushes.Black, width / 2, getHeight((int)TicketElements.headerText), centered());

            e.Graphics.DrawString($"REMISIÓN NÚMERO: {remision}", Fonts.sanSerifRegularLarge, Brushes.Black, width / 2, getHeight((int)TicketElements.remision), centered());
            drawLine(e, true);
        }

        private void drawLine(PrintPageEventArgs e, bool isBold)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, isBold ? 4 : 2), new Point(marginLeft, getHeight((int)TicketElements.largeSpacing)), new Point(width - marginLeft, spacingHeight));
        }

        private void drawSmallLine(PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(marginLeft, getHeight((int)TicketElements.largeSpacing)), new Point(width - marginLeft, spacingHeight));
        }

        public void AddFooter(PrintPageEventArgs e)
        {
            getHeight((int)TicketElements.headerText);
            e.Graphics.DrawString($"Fecha {DateTime.UtcNow.Date.ToString("dd/MM/yyyy")}", Fonts.sanSerifbold, Brushes.Black, marginLeft, spacingHeight, near());
            e.Graphics.DrawString($"HORA {DateTime.Now.ToShortTimeString()}", Fonts.sanSerifbold, Brushes.Black, width - marginLeft, spacingHeight + (int)TicketElements.headerText, far());
            getHeight((int)TicketElements.product);
            e.Graphics.DrawString("¡Gracias por su preferencia!", Fonts.sanSerifRegular, Brushes.Black, width / 2, getHeight((int)TicketElements.headerText), centered());

            e.Graphics.Dispose();
        }

        public void AddDisclaimer(PrintPageEventArgs e)
        {
            if (isDisclaimerNeeded)
            {
                //e.Graphics.DrawString($"{legalData.leyend1}", Fonts.sanSerifRegular, Brushes.Black, width / 2, getHeight((int)TicketElements.headerText), centered());
                //e.Graphics.DrawString($"{legalData.leyend6}", Fonts.sanSerifRegular, Brushes.Black, new RectangleF(marginLeft, width - marginLeft, 0, 500F));
                //e.Graphics.DrawString($"{legalData.leyend6}", Fonts.sanSerifRegular, Brushes.Black, new RectangleF(marginLeft, width - marginLeft, 500F, 500F));
                e.Graphics.DrawString($"{legalData.leyend6}", Fonts.sanSerifRegular, Brushes.Black, new RectangleF(marginLeft, getHeight((int)TicketElements.headerText), width - (marginLeft * 2), 500F));

                getHeight((int)TicketElements.disclaimer);
            }
        }

        public void AddProducts(PrintPageEventArgs e)
        {
            if (products.Count > 0)
            {
                setDataIfExist(e, "", "PRODUCTOS", true);

                getHeight((int)TicketElements.headerText);
                e.Graphics.DrawString("CANT.   NOMBRE", Fonts.sanSerifbold, Brushes.Black, marginLeft, spacingHeight, near());
                e.Graphics.DrawString("P.UNIT   IMPORTE", Fonts.sanSerifbold, Brushes.Black, width - marginLeft, spacingHeight + (int)TicketElements.headerText, far());
                getHeight((int)TicketElements.product);

                foreach (ProductItem product in products)
                {
                    if (product.isResponsive)
                    {
                        isDisclaimerNeeded = true;
                    }

                    getHeight((int)TicketElements.normalSpacing);
                    e.Graphics.DrawString($"     {product.items}      {product.name}", Fonts.sanSerifRegular, Brushes.Black, marginLeft, spacingHeight, near());
                    e.Graphics.DrawString($"${product.price}          ${product.price * product.items}", Fonts.sanSerifRegular, Brushes.Black, width - marginLeft, spacingHeight + (int)TicketElements.headerText, far());
                    getHeight((int)TicketElements.normalSpacing);
                    drawSmallLine(e);
                }
            }

            drawLine(e, false);
        }

        public void AddClient(PrintPageEventArgs e)
        {
            Client client = CurrentClient.GetCurrentClientInstance();

            if (client == null) return;
            
            setDataIfExist(e, "Cliente:", client.name, false);
            setDataIfExist(e, "Teléfono:", client.phone, false);
            setDataIfExist(e, "Alternativo:", client.alternativePhone, false);
            setDataIfExist(e, "Correo:", client.email, false);

            AddPet(e);

            getHeight((int)TicketElements.smallSpacing);
            drawLine(e, true);
        }

        public void AddPet(PrintPageEventArgs e)
        {
            getHeight((int)TicketElements.headerText);
            drawSmallLine(e);
            setDataIfExist(e, "Mascota:", CurrentPet.GetName(), false);
            setDataIfExist(e, "Estado:", CurrentPet.GetStatus(), false);
        }

        private void setDataIfExist(PrintPageEventArgs e, string type, string data, bool isCentered)
        {
            if (data != null && data.Length > 0)
            {
                e.Graphics.DrawString($"{type} {data}", Fonts.sanSerifRegular, Brushes.Black, isCentered ? width / 2 : marginLeft, getHeight((int)TicketElements.headerText), near());
            }
        }

        public void PrintTicket()
        {
            printDocument = new PrintDocument();
            printDocument.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
            printDocument.PrintPage += new PrintPageEventHandler(printPage);
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Test", width, GetPosibleHeight());
            
            saveTicketInformation();

            try
            {
                printDocument.Print();
                listener.SuccessPrinting();
            }
            catch (Exception exception)
            {
                listener.ErrorPrinting(exception);
                return;
            }
            /*
            try
            {
                saveTicketInformation();
            }
            catch (Exception exception)
            {
                Notifications.NotificationsCenter.ShowWarningMessage("Los datos del ticket no se pudieron guardar.");
            }*/
        }

        private int getHeight(int spacing)
        {
            spacingHeight += spacing;
            return spacingHeight;
        }

        private StringFormat centered()
        {
            StringFormat stringFormat = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            };
            return stringFormat;
        }

        private StringFormat near()
        {
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Near
            };
            return stringFormat;
        }

        private StringFormat far()
        {
            StringFormat stringFormat = new StringFormat
            {
                LineAlignment = StringAlignment.Far,
                Alignment = StringAlignment.Far
            };
            return stringFormat;
        }

        public Image ScaleImage(PrintPageEventArgs e, Image image, int maxWidth, int maxHeight)
        {
            double ratioX = (double)maxWidth / image.Width;
            double ratioY = (double)maxHeight / image.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            Bitmap newImage = new Bitmap(maxWidth, maxHeight);
            int y = (maxHeight / 2) - newHeight / 2;
            int x = (width - logoWidth) / 2;

            e.Graphics.DrawImage(image, x, getHeight((int)TicketElements.logo), newWidth, newHeight);

            return newImage;
        }

        private int GetPosibleHeight()
        {
            int height = 350;
            int spacePerElement = ((int)TicketElements.normalSpacing * 2) + (int)TicketElements.largeSpacing;

            if (CurrentClient.GetCurrentClientInstance() != null) height += (int)TicketElements.largeSpacing*4;

            height += spacePerElement * products.Count;
            height += spacePerElement * services.Count;
            height += ((int)TicketElements.headerText + (int)TicketElements.product) * 4;

            if (isDisclaimerNeeded)
            {
                height += (int)TicketElements.disclaimer;
            }
            return height;
        }

        private void saveTicketInformation()
        {
            if (CurrentClient.GetCurrentClientInstance() != null && CurrentClient.GetCurrentClientInstance().id != null)
            {
                new SQL().saveTicketInformation(remision, CurrentClient.GetCurrentClientInstance().id, decimal.Parse(total + ""));
            }
            else
            {
                new SQL().saveTicketInformation(remision, 0.ToString(), decimal.Parse(total + ""));
            }
        }
    }
}
