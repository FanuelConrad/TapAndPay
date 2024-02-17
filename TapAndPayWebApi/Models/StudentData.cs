using System.ComponentModel.DataAnnotations;

namespace TapAndPayWebApi.Models
{
    public class StudentData
    {
        [Key]
        public string AdmissionNumber { get; set; }
        public string RFID_UID { get; set; }
    }
}