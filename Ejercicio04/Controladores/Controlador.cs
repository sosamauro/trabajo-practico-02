using Ejercicio04.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04.Controladores
{
    public static class Controlador
    {
        public static string[] InicializarArregloPalabras()
        {
            String[] arregloPalabra = new string[30];

            arregloPalabra[0] = "Vitamina Sanchez";
            arregloPalabra[1] = "Mugre Corbalan";
            arregloPalabra[2] = "Satanas Paez";
            arregloPalabra[3] = "Hachita Ludueña";
            arregloPalabra[4] = "Discoteca Nuñez";
            arregloPalabra[5] = "Almanaque Gonzalez";
            arregloPalabra[6] = "Lechuga Roa";
            arregloPalabra[7] = "Fosa Pereyra";
            arregloPalabra[8] = "Fatura Broun";
            arregloPalabra[9] = "Manteca Martinez";
            arregloPalabra[10] = "Mostaza Merlo";
            arregloPalabra[11] = "Garrafa Sanchez";
            arregloPalabra[12] = "Motoneta Penco";
            arregloPalabra[13] = "Sopa Aguilar";
            arregloPalabra[14] = "Puchero Varacka";
            arregloPalabra[15] = "Uvita Fernandez";
            arregloPalabra[16] = "Hacha Brava Navarro";
            arregloPalabra[17] = "Feo Labruna";
            arregloPalabra[18] = "Facha Bartelt";
            arregloPalabra[19] = "Rifle Castellano";
            arregloPalabra[20] = "Mago Capria";
            arregloPalabra[21] = "Comisario Colman";
            arregloPalabra[22] = "Cebolla Rodríguez";
            arregloPalabra[23] = "Leche La Paglia";
            arregloPalabra[24] = "Yerbatero Gonzalez";
            arregloPalabra[25] = "Jardinero Cruz";
            arregloPalabra[26] = "Malevo Ferreyra";
            arregloPalabra[27] = "Chapa Suñe";
            arregloPalabra[28] = "Chancha Rinaldi";
            arregloPalabra[29] = "Chilo Chiloteguy";

            return arregloPalabra;
        }

        public static void CrearPartida(string pJugador)
        {
            Partida pPartida = new Partida(pJugador, DateTime.Now);
        }

        // Devuelve un arreglo de tipo STRING de la palabra a adivinar.
        public static string ObtenerPalabra(string[] pPalabras)
        {
            // Este código selecciona un integer aleatorio entre 0 y 29; y lo devuelve.
            // Este valor representa el index de la palabra en el arreglo.
            Random rd = new Random();
            int randomIndex = rd.Next(0, 29);

            return pPalabras[randomIndex];
        }

        // Devuelve un arreglo del tamaño de la palabra, pero en vez de letras
        public static string[] CrearArregloConPalabra(string pPalabra)
        {
            string[] arregloPalabra = new string[pPalabra.Length];

            for (int i = 0; i < pPalabra.Length; i++)
            {
                if (Char.IsWhiteSpace(pPalabra, i))
                {
                    arregloPalabra[i] = " ";
                }
                else
                {
                    arregloPalabra[i] = "_";
                }
            }

            return arregloPalabra;
        }

        public static string[] AgregarLetraCorrecta(string[] pArregloPalabra, string pPalabra, string pLetra)
        {
            for (int i = 0; i < pPalabra.Length; i++)
            {
                if ((Convert.ToString(pPalabra[i]) == pLetra.ToUpper()) | (Convert.ToString(pPalabra[i]) == pLetra.ToLower()))
                {
                    pArregloPalabra[i] = pLetra;
                }
            }
            
            return pArregloPalabra;
        }

        public static void MostrarArreglo(string[] pArregloPalabra)
        {
            for (int i = 0; i < pArregloPalabra.Length; i++)
            {
                Console.Write(pArregloPalabra[i]);
                Console.Write(" ");
            }
        }

        public static bool PalabraCompleta(string[] pArregloPalabra)
        {
            for (int i = 0; i < pArregloPalabra.Length; i++)
            {
                if (pArregloPalabra[i] == "_")
                {
                    return false;
                }
            }

            return true;
        }

        public static bool HayCoincidencia(string pPalabra, string pLetra)
        {
            for (int i = 0; i < pPalabra.Length; i++)
            {
                if ((pLetra.ToUpper() == Convert.ToString(pPalabra[i])) | (pLetra.ToLower() == Convert.ToString(pPalabra[i]))) 
                {
                    return true;
                }
            }
            return false;
        }

        public static ArrayList CrearArregloFallos()
        {
            ArrayList arregloFallos = new ArrayList();
            return arregloFallos;
        }

        public static void AgregarLetraArregloFallos(ArrayList pArregloFallos, string pLetra)
        {
            pArregloFallos.Add(pLetra.ToUpper());
        }

        public static void MostrarArregloFallos(ArrayList pArregloFallos)
        {
            foreach (var i in pArregloFallos)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
