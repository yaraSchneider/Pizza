using Microsoft.Extensions.DependencyInjection;
using Pizza02.Aplicação.Servicos;
using Pizza02.Dominio.Entidades;

namespace Pizza02
{
    public partial class FormPizzaCadastro : Form
    {

        private readonly IPizzaAppServico _servico;
        public FormPizzaCadastro(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _servico = serviceProvider.GetRequiredService<IPizzaAppServico>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textPizza.Text))
            {
                MessageBox.Show("Sabor do produto é obrigatório");
                return;
            }

            if (!decimal.TryParse(textPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(textId.Text))
                {
                    _servico.CadastrarPizza(textPizza.Text, decimal.Parse(textPreco.Text));
                    MessageBox.Show("Produto salvo com sucesso!");
                    CarregarPizza();
                }
                else
                {
                    _servico.AlterarPizza(int.Parse(textId.Text), textPizza.Text, decimal.
                        Parse(textPreco.Text));
                    MessageBox.Show("Produto atualizado com sucesso!");
                    CarregarPizza();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro de salvar produto: {ex.Message}");
            }
        }

        private void FrmControleEstoque_Load(object sender, EventArgs e)
        {
            CarregarPizza();
        }

        private void CarregarPizza()
        {
            var pizza = _servico.GetPizza();

            dtgEstoque.DataSource = pizza;

            dtgEstoque.Columns["Id"].HeaderText = "ID";
            dtgEstoque.Columns["SaborPizza"].HeaderText = "Sabor da Pizza";
            dtgEstoque.Columns["Preco"].HeaderText = "Preço";
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textId.Text) || !int.TryParse(textId.Text, out int id))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }

            if (string.IsNullOrEmpty(textPizza.Text))
            {
                MessageBox.Show("Sabor da Pizza é obrigatório.");
                return;
            }
            if (!decimal.TryParse(textPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido.");
                return;
            }
            try
            {
                var pizza = new Pizza(int.Parse(textId.Text), textPizza.Text, decimal.Parse(textPreco.Text));
                _servico.ExcluirPizza(pizza);
                MessageBox.Show("Produto excluido com sucesso");
                CarregarPizza();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o produto: {ex.Message}");
            }

        }

        private void dtgEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pizzaSelecionado = dtgEstoque.Rows[e.RowIndex].DataBoundItem as Pizza;

                if (pizzaSelecionado != null)
                {
                    textId.Text = pizzaSelecionado.Id.ToString();
                    textPizza.Text = pizzaSelecionado.SaborPizza;
                    textPreco.Text = pizzaSelecionado.Preco.ToString("F2");
                }
            }
        }

        private void FormPizzaCadastro_Load(object sender, EventArgs e)
        {
           
        }

        private void Limpar()
        {
            textId.Clear();
            textPizza.Clear();
            textPreco.Clear();
        }
    }
}
