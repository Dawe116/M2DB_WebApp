using M2DB_WebApp.DTOs;
using M2DB_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace M2DB_WebApp.Services
{
    public class AlkoholService
    {
        public static List<Alkohol> GetAlkohol()
        {
            var context = new AlkoholContext();
            try
            {
                var response = context.Alkohols.ToList();
                return response;
            }
            catch(Exception ex)
            {
                List<Alkohol> alkohols = new List<Alkohol>();
                Alkohol alkohol = new Alkohol();
                alkohol.Id = -1;
                alkohol.Nev = ex.Message;
                alkohols.Add(alkohol);
                return alkohols;
            }
        }

        public static List<AlkoholDTO> GetAlkoholDTOs()
        {

            var context = new AlkoholContext();
            try
            {
                var valasz = context.Alkohols.Include(f => f.Gyarto).Include(f => f.Kategoria).Select(f => new AlkoholDTO() { 
                    Nev = f.Nev, 
                    AlkoholFox = f.AlkoholFox, 
                    Ar =  f.Ar, 
                    GyartoCim = f.Gyarto.Cim, 
                    GyartoNev = f.Gyarto.Nev, 
                    GyartoOrszag = f.Gyarto.SzarmazasiHely, 
                    KategoriaNev = f.Kategoria.Nev, 
                    Urtartlokom = f.Urtartlokom}).ToList();
                return valasz;
            }
            catch(Exception ex )
            {
                List<AlkoholDTO> alkoholDTOs = new List<AlkoholDTO>();
                AlkoholDTO alkoholDTO = new AlkoholDTO();
                alkoholDTO.Ar = -1;
                alkoholDTO.Nev = ex.Message;
                alkoholDTOs.Add(alkoholDTO);
                return alkoholDTOs;
            }
        }
    }
}
