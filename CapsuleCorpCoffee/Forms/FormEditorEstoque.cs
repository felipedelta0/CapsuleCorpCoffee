﻿using CapsuleCorpCoffeeBUS.Classes;
using CapsuleCorpCoffeeDTO.Classes;
using CapsuleCorpCoffeeBUS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapsuleCorpCoffee.Forms
{
    public partial class FormEditorEstoque : Form
    {
        #region Propriedades, Váriaveis e Atributos

        private Estoque ItemEstoque;
        private EstoqueBUS estoqueBUS;
        private CapsulaBUS capsulaBUS;
        private bool IsEditar = false;

        #endregion

        #region Construtores
        public FormEditorEstoque()
        {
            ItemEstoque = new Estoque();

            InitializeComponent();

            DefinirTitulo();
            InicializarBUS();
        }

        public FormEditorEstoque(Estoque item)
        {
            InitializeComponent();

            ItemEstoque = item;
            IsEditar = true;

            DefinirTitulo();
            InicializarBUS();
        }
        #endregion

        #region Eventos
        private void FormEditorItemEstoque_Load(object sender, EventArgs e)
        {
            CarregarCapsulas();

            if (this.IsEditar)
            {
                datePicker.Value = ItemEstoque.Validade;
                txtQuantidade.Text = ItemEstoque.Quantidade.ToString();

                this.txtQuantidade.Text = ItemEstoque.Quantidade.ToString();
                this.datePicker.Value = ItemEstoque.Validade;
            }

            cmbCapsula.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarComboBox())
            {
                MontarRegistro();

                if (this.estoqueBUS.ValidarCampos(this.ItemEstoque))
                {
                    if (this.estoqueBUS.Salvar(this.ItemEstoque))
                        MessageBox.Show("Registro salvo com sucesso!", "Sucesso");
                    else
                        MessageBox.Show("Erro ao salvar o registro. Tente novamente", "Erro ao Salvar");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registro inválido. Favor verificar todos os campos", "Erro ao Validar");
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado.", "Erro ao Validar");
                return;
            }
        }
        #endregion

        #region Métodos
        private void CarregarCapsulas()
        {
            PopularComboBox();

            cmbCapsula.DisplayMember = "Descricao";
        }

        private void PopularComboBox()
        {
            List<Capsula> capsulas = capsulaBUS.Listar();

            cmbCapsula.Items.Clear();

            int index = 0;

            foreach (Capsula capsula in capsulas)
            {
                cmbCapsula.Items.Add(capsula);
                if (IsEditar && capsula.ID == this.ItemEstoque.Capsula)
                {
                    index = cmbCapsula.Items.Count - 1;
                }
            }

            cmbCapsula.SelectedIndex = capsulas.Count > 0 ? index : -1;
        }

        private void MontarRegistro()
        {
            int.TryParse(txtQuantidade.Text.ToString(), out int quantidade);

            this.ItemEstoque.Capsula = cmbCapsula.SelectedItem == null ? -1 : ((Capsula)cmbCapsula.SelectedItem).ID;
            this.ItemEstoque.Quantidade = quantidade;
            this.ItemEstoque.Validade = datePicker.Value;
        }

        private bool ValidarComboBox()
        {
            if (cmbCapsula.SelectedItem == null)
                return false;
            return true;
        }

        private void InicializarBUS()
        {
            estoqueBUS = FactoryBUS.CreateEstoqueBUS();
            capsulaBUS = FactoryBUS.CreateCapsulaBUS();
        }

        private void DefinirTitulo()
        {
            if (this.IsEditar)
                this.Text = "Edição de Item de Estoque";
            else
                this.Text = "Nova Item de Estoque";
        }
        #endregion
    }
}
