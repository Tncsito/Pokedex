﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Pokedex_EESA.Vista.Pokemon;

namespace Pokedex_EESA.VistaModelo.VMPokemon
{
    public class VMlistapokemon:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion

        #region CONTRUCTOR

        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        #region PROCESOS
        public async Task Iraregistro()
        {
            await Navigation.PushModalAsync(new RegistrarPokemon());
        }

        public void ProcesoSimple()
        {
        }
        #endregion

        #region COMANDOS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion

        #region CONTRUCTOR
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
    }
}
