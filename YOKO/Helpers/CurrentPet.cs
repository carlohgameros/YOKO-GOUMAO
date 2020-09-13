using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YOKO.enums;

namespace YOKO.Models
{
    public class CurrentPet
    {
        private static CurrentPet currentPetInstance;
        private int id;
        private String name;
        private String breed;
        private PetStatusEnum status;

        public CurrentPet(int id, string name, PetStatusEnum status, string breed)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.breed = breed;
        }

        public static CurrentPet GetCurrentPetInstance(CurrentPet currentPet)
        {
            if (currentPetInstance == null)
            {
                currentPetInstance = currentPet;
            }

            return currentPetInstance;
        }

        public static void SetCurrentPet(int id, string name, PetStatusEnum status, string breed)
        {
            currentPetInstance = new CurrentPet(id, name, status, breed);
        }

        public static void SetCurrentPet(CurrentPet currentPet)
        {
            currentPetInstance = currentPet;
        }

        public static int? GetID()
        {
            return currentPetInstance?.id;
        }

        public static string GetName()
        {
            return currentPetInstance?.name;
        }

        public static void SetStatus(PetStatusEnum status)
        {
            if (currentPetInstance != null)
            {
                currentPetInstance.status = status;
            }
        }

        public static string GetStatus()
        {
            if (currentPetInstance == null)
            {
                return "";
            }

            switch (currentPetInstance.status)
            {
                case PetStatusEnum.ErrorDeRegistro:
                    return "Sin registro";
                case PetStatusEnum.PocosRegistrosNegativos:
                    return "Pocos registros negativos";
                case PetStatusEnum.RegistrosNegativos:
                    return "Registros negativos";
                case PetStatusEnum.SinRegistro:
                    return "No registros";
                case PetStatusEnum.SinRegistrosNegativos:
                    return "Sin registros negativos";
                default:
                    return "";
            }
        }

        private static string GetBreed()
        {
            return currentPetInstance?.breed;
        }
    }
}
