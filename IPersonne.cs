using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public interface IPersonne
    {
        string SS { get;}
        string Nom { get; set; }
        string Prenom { get;}
        DateTime Naissance { get; }
        string Adresse { get; set; }
        string Mail { get; set; }
        string Telephone { get; set; }
    }
}
