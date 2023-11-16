using System;
using System.Collections.Generic;
using System.Text;
using Pokedex_EESA.Modelo;
using Pokedex_EESA.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Pokedex_EESA.Datos
{
    public class Dpokemon
    {
        public async Task Insertarpokemon(Mpokemon parametros)
        {
            await Cconexion.firebase.Child("Pokemon").PostAsync(new Mpokemon()
            {
                 ColorFondo = parametros.ColorFondo,
                 Colorpoder = parametros.Colorpoder,
                 Icono = parametros.Icono,
                 Nombre = parametros.Nombre,
                 Nroorden = parametros.Nroorden,
                 Poder = parametros.Poder,
            });
        }
        public async Task<List<Mpokemon>> MostrarPokemones()
        {
            return (await Cconexion.firebase.Child("Pokemon").OnceAsync<Mpokemon>()).Select(item => new Mpokemon
            {
                Idpokemon = item.Key,
                Nombre = item.Object.Nombre,
                ColorFondo = item.Object.ColorFondo,
                Colorpoder = item.Object.Colorpoder,
                Nroorden = item.Object.Nroorden,
                Poder = item.Object.Poder,
                Icono = item.Object.Icono
            }).ToList();
        }
    }
}
