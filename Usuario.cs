using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas
{
   public class Usuario
    {
        //propriedades da classe
        //colunas da tabela Usuario
        [Key] //Chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // AI (auto incremento)
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string senha { get; set; } = string.Empty;

    }
}
