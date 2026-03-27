using OrderBL.Interfaces;
using OrderDL;

namespace OrderUtil {
    public class RepositoryFactory {

        
            public static ILidRepository GeefLidRepository(string opslagType) {
                switch (opslagType) {
                    case "COLLECTIONS":
                       
                        return new LidRepository();

               
                    default: return null;
                       
                }
            }

        public static IEventRepository GeefEventRepository(string opslagType) {
            switch (opslagType) {
                case "COLLECTIONS":

                    return new EventRepository();


                default: return null;

            }
        }


        public static IBestellingRepository GeefBestellingRepository(string opslagType) {
            switch (opslagType) {
                case "COLLECTIONS":

                    return new BestellingRepository();


                default: return null;

            }
        }
    }

    }

