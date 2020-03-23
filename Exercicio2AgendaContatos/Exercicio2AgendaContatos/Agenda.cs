using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2AgendaContatos
{
    class Agenda
    {
        public List<string> ListaCompleta { get; private set; }

        public Agenda()
        {
            ListaCompleta = new List<string>();
        }
        public void AdicionarContato(string contato)
        {
            ListaCompleta.Add(contato);
        }

        public void RemoverContato(string contato)
        {
            ListaCompleta.Remove(contato);
        }

        public List<String> BuscarContatoPorLetra(char letra)
        {
            List<String> busca = new List<string>();

            foreach (string contato in ListaCompleta)
            {
                if (char.ToLower(contato[0]) == char.ToLower(letra))
                {
                    busca.Add(contato);
                }
            }

            return busca;
        }
    }
}
