using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCoreSolucaoUm_04_11_19.Model
{
    public partial class Objeto
    {
        [Key]
        public int Id { get; set; }
        public double Densidade { get; set; }
        public double VolumeTotal { get; set; }

        public Double Peso
        {
            get { return (( VolumeTotal * Densidade) * 9.8); }
        }

    }
}
