using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    class cVehiculo
    {
        int Cant_viajes_max;
        string Modelo;
        int Carga_max;
        int Carga_act;
        bool Elevador;
        Stack<Pedido> PedidosHoy; // una pila        tu pila y mi cola     NO ANDA STACKKKKKKKKKKK
        int Nafta_max;
        int Nafta_act;


        public void Ir(destino Destino) { }  //no se   que onda esto pero le tengo que poner public a cada metodo, no se como hacer el constructor y destructor
        public void Repartir(Pedido pedido) { }
        public void CargarNafta() { }
    }

    
}

