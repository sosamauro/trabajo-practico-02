using System;
using Ejercicio04.Clases;

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
            arregloPalabra[15] = "Uvita Fernández";
            arregloPalabra[16] = "Hacha Brava Navarro";
            arregloPalabra[17] = "Feo Labruna";
            arregloPalabra[18] = "Facha Bartelt";
            arregloPalabra[19] = "Rifle Castellano";
            arregloPalabra[20] = "Mago Capria";
            arregloPalabra[21] = "Comisario Colman";
            arregloPalabra[22] = "Cebolla Rodríguez";
            arregloPalabra[23] = "Leche La Paglia";
            arregloPalabra[24] = "Yerbatero González";
            arregloPalabra[25] = "Jardinero Cruz";
            arregloPalabra[26] = "Malevo Ferreyra";
            arregloPalabra[27] = "Chapa Suñe";
            arregloPalabra[28] = "Chancha Rinaldi";
            arregloPalabra[29] = "Chaucha Bianco";

            return arregloPalabra;
        }

        public static void CrearPartida(string pJugador)
        {
            Partida pPartida = new Partida(pJugador, DateTime.Now);
        }
    }
}