using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace WebNieruchomosci.Models
    {
        public class Nieruchomosc
        {
            [Key]
            public int Id { get; set; }
            [Required]
            private string ulica;
            private string miasto;
            private int nrDomu;
            private int? nrMieszkania;
            private string kodPocztowy;
            public string Kraj { get; set; }

            public string Ulica
            {
                get
                {
                    return ulica;
                }

                set
                {
                    ulica = value;
                }
            }

            public string Miasto
            {
                get
                {
                    return miasto;
                }

                set
                {
                    miasto = value;
                }
            }

            public int NrDomu
            {
                get
                {
                    return nrDomu;
                }

                set
                {
                    nrDomu = value;
                }
            }

            public int? NrMieszkania
            {
                get
                {
                    return nrMieszkania;
                }

                set
                {
                    nrMieszkania = value;
                }
            }

            public string KodPocztowy
            {
                get
                {
                    return kodPocztowy;
                }

                set
                {
                    kodPocztowy = value;
                }
            }


           
        }
    }
