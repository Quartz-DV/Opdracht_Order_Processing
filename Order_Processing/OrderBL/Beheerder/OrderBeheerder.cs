using OrderBL.Domein;
using OrderBL.Lidklassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBL.Beheerder {
    public class OrderBeheerder {


        private LidRepository LidRepository;
        private LidServices LidServices;

        public OrderBeheerder(LidRepository lidRepository, LidServices lidServices) {
            LidRepository = lidRepository;
            LidServices = lidServices;
        }

        public void LidTaken(Lid lid) {

            LidRepository.RegistreerLid(lid);

            




        }




    }
}
