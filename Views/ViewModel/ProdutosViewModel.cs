﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using Model;

namespace Views.ViewModel
{
    public class ProdutosViewModel  : DependencyObject
    {
        public string Descricao
        {
            get { return (string)GetValue(DescricaoProperty); }
            set { SetValue(DescricaoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Descricao.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DescricaoProperty =
            DependencyProperty.Register("Descricao", typeof(string), typeof(ProdutosViewModel), new PropertyMetadata(string.Empty));




        public List<ProdutoModel> ListaDescricao
        {
            get { return (List<ProdutoModel>)GetValue(ListaDescricaoProperty); }
            set { SetValue(ListaDescricaoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ListaDescricao.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ListaDescricaoProperty =
            DependencyProperty.Register("ListaDescricao", typeof(List<ProdutoModel>), typeof(ProdutosViewModel), new PropertyMetadata(new List<ProdutoModel>()));





        public ProdutosViewModel()
        {
            LoadMockupData();
        }

        private void LoadMockupData()
        {
            Descricao = "Teste";

            var lista = new List<ProdutoModel>
            {
                new ProdutoModel { Descricao = "Teste1" },
                new ProdutoModel { Descricao = "Teste2" },
                new ProdutoModel { Descricao = "Teste3" }
            };

            ListaDescricao = lista;
        }
    }
}

