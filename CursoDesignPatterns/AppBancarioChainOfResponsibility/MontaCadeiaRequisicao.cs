using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.AppBancarioChainOfResponsibility
{
    public class MontaCadeiaRequisicao 
    {
        public string RetornaFormato(Requisicao requisicao, Conta conta)
        {
            var formatoXml = new FormatoRetornoXml();
            var formatoCsv = new FormatoRetornoCsv();
            var formatoPorcento = new FormatoRetornoPorcento();
            var semFormato = new SemFormato();

            formatoXml.ProximoFormato = formatoCsv;
            formatoCsv.ProximoFormato = formatoPorcento;
            formatoPorcento.ProximoFormato = semFormato;


            return formatoXml.FormatoRetorno(conta, requisicao.Formato);
        }

    }
}
