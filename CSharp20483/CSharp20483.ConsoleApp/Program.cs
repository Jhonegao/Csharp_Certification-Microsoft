﻿using CSharp20483.Tipos;
using CSharp20483.Aula13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20483.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World\n");
            TiposVariaveis tipos = new TiposVariaveis();
            //tipos.Executar();
            TipoIntegrais ti = new TipoIntegrais();
            //ti.Executar();
            TiposFlutantes tf = new TiposFlutantes();
            //tf.Executar();
            TipoEstruturais te = new TipoEstruturais();
            //te.Executar();
            TipoReferencias tr = new TipoReferencias();
            //tr.Executar();
            UsandoTipos ut = new UsandoTipos();
            //ut.Execute();
            OutrosTipos ot = new OutrosTipos();
            //ot.Executar();
            Delegados dl = new Delegados();
            dl.Executar();
            Console.ReadKey();
        }
    }
}
