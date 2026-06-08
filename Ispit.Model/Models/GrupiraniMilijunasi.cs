using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit.Model.Models;

public class GrupiraniMilijunasi
{
    public string Banka { get; set; }
    public IEnumerable<string> Milijunasi {  get; set; }
}
