using System;

namespace YOKO.Models
{
    public class Service
    {
        public int ID { get; set; }
        public DateTime requestTime { get; set; }
        public DateTime? startTime { get; set; }
        public DateTime? finishTime { get; set; }
        public bool finished { get; set; }
        public string description { get; set; }
        public string observations { get; set; }
        public int petID { get; set; }
        public int ownerID { get; set; }
        public bool canceled { get; } 

        private bool isActive = false;
        private bool isStoped = false;
        private bool isCanceled = false;

        public Service(int ID, string description, int petID, int ownerID, string observations = "")
        {
            this.ID = ID;
            this.requestTime = DateTime.Now;
            this.startTime = new DateTime();
            this.finishTime = new DateTime();
            this.finished = false;
            this.description = description;
            this.observations = observations;
            this.petID = petID;
            this.ownerID = ownerID;
            canceled = false;ID
        }

        public void finishService()
        {
            this.finishTime = DateTime.Now;
            this.finished = true;
        }

        public void startService()
        {
            this.startTime = DateTime.Now;
            isActive = true;
            isStoped = false;
        }

        public void changeDescription(string description) => this.description = description;
        public void changeObservations(string observations) => this.observations = observations;

        public void stopService()
        {
            isActive = false;
            isStoped = false;
        }

        public void cancelService()
        {
            
        }
    }
}
