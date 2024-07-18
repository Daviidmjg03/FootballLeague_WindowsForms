using BibiliotecaLigaNos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ParagraphLayout = iText.Layout.Element.Paragraph;
using ParagraphText = iTextSharp.text.Paragraph;
using LigaNosEarredores.Properties;
using System.Text.RegularExpressions;

namespace LigaNosEarredores
{
    public partial class ClubesForms : Form
    {
        List<Clubes> clubes;
        public event EventHandler<Clubes> ClubeAdicionado;
        int contaClubes = 1;
        int ClassificaoGeral;
        int jogosRealizados;
        int golosMarcados;
        int golosSofridos;
        int vitoriasCasa;
        int vitoriasFora;
        int empates;
        int derrotas;

        /// <summary>
        /// Construtor da classe ClubesForms. Inicializa a lista de clubes e o formulário.
        /// </summary>
        public ClubesForms()
        {
            clubes = new List<Clubes>();
            InitializeComponent();
            InitLista();
        }

        /// <summary>
        /// Determina o clube campeão com base na classificação geral.
        /// </summary>
        /// <returns>O clube com a maior classificação geral.</returns>
        private Clubes DeterminarCampeao()
        {
            Clubes campeao = null;
            int maiorPontuacao = int.MinValue;

            foreach (Clubes clube in clubes)
            {
                if (clube.ClassificaoGeral > maiorPontuacao)
                {
                    maiorPontuacao = clube.ClassificaoGeral;
                    campeao = clube;
                }
            }

            return campeao;
        }

        /// <summary>
        /// Evento ao carregar o formulário. Carrega os clubes e IDs de ficheiros.
        /// </summary>
        private void ClubesForms_Load(object sender, EventArgs e)
        {
            CarregarFicheiros.CarregarClubes(clubes, @"Clubes.txt");
            contaClubes = CarregarFicheiros.CarregarClubesID(@"IdClubes.txt");
            InitLista();
        }

        /// <summary>
        /// Evento ao clicar no botão de adicionar clube.
        /// Valida os campos e adiciona um novo clube à lista.
        /// </summary>
        private void btnAdicionarClube_Click(object sender, EventArgs e)
        {
            if (CamposPreenchidos())
            {
                if (!Regex.IsMatch(textBoxNomeClube.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("O nome do clube deve conter apenas letras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(textBoxEstadio.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("O nome do estádio deve conter apenas letras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(textBoxCidade.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("O nome da cidade deve conter apenas letras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(textBoxAnoFundacao.Text, out int anoFundacao))
                {
                    MessageBox.Show("Por favor, insira um ano de fundação válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(textBoxTrofeus.Text, out int trofeus))
                {
                    MessageBox.Show("Por favor, insira um número válido de troféus.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (clubes.Any(c => c.NomeClube == textBoxNomeClube.Text &&
                                     c.NomeEstadio == textBoxEstadio.Text &&
                                     c.AnoFundacao == anoFundacao))
                {
                    MessageBox.Show("Já existe um clube com este nome, estádio e ano de fundação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var novoClube = new Clubes(textBoxNomeClube.Text, textBoxCidade.Text, textBoxEstadio.Text, anoFundacao, trofeus, ClassificaoGeral, jogosRealizados, golosMarcados, golosSofridos, vitoriasCasa, vitoriasFora, derrotas, empates, contaClubes);
                clubes.Add(novoClube);
                contaClubes++;
                ClubeAdicionado?.Invoke(this, novoClube);
                LimparCampos();
                SalvarDados();
                InitLista();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento ao clicar no botão de atualizar clube.
        /// Atualiza os dados do clube selecionado.
        private void btnAtualizarClube_Click(object sender, EventArgs e)
        {
            if (listBoxResultados.SelectedIndex != -1)
            {
                int indiceSelecionado = listBoxResultados.SelectedIndex;
                AtualizarClubeForms atualizarClubeForm = new AtualizarClubeForms(clubes[indiceSelecionado]);
                if (atualizarClubeForm.ShowDialog() == DialogResult.OK)
                {
                    clubes[indiceSelecionado] = atualizarClubeForm.ClubeAtualizado;
                    InitLista();
                    SalvarDados();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um clube para atualizar.");
            }
        }

        /// <summary>
        /// Evento ao clicar no botão de apagar clube.
        /// Remove o clube selecionado da lista.
        /// </summary>
        private void btnApagarClube_Click(object sender, EventArgs e)
        {
            if (listBoxResultados.SelectedIndex != -1)
            {
                clubes.RemoveAt(listBoxResultados.SelectedIndex);
                InitLista();
                SalvarDados();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um clube para apagar.");
            }
        }

        /// <summary>
        /// Inicializa a lista de clubes na ListBox.
        /// </summary>
        public void InitLista()
        {
            listBoxResultados.DataSource = null;
            listBoxResultados.DataSource = clubes;
            listBoxResultados.DisplayMember = "Descricacaoclube";
        }

        /// <summary>
        /// Verifica se todos os campos obrigatórios estão preenchidos.
        /// </summary>
        /// <returns>True se todos os campos estiverem preenchidos, caso contrário, False.</returns>
        private bool CamposPreenchidos()
        {
            if (string.IsNullOrEmpty(textBoxNomeClube.Text))
            {
                MessageBox.Show("Insira o nome do Clube", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxCidade.Text))
            {
                MessageBox.Show("Insira o nome da cidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxEstadio.Text))
            {
                MessageBox.Show("Insira o nome do estádio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxAnoFundacao.Text))
            {
                MessageBox.Show("Insira o ano de fundação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxTrofeus.Text))
            {
                MessageBox.Show("Insira o numero de trofeus", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Limpa os campos de entrada de dados do formulário.
        /// </summary>
        private void LimparCampos()
        {
            textBoxNomeClube.Clear();
            textBoxCidade.Clear();
            textBoxEstadio.Clear();
            textBoxAnoFundacao.Clear();
            textBoxTrofeus.Clear();
        }

        /// <summary>
        /// Salva os IDs e dados dos clubes em ficheiros de texto.
        /// </summary>
        private void SalvarDados()
        {
            GuardarFicheiros.GravarClubesID(contaClubes, @"IdClubes.txt");
            GuardarFicheiros.GravarClubes(clubes, @"Clubes.txt");
        }

        /// <summary>
        /// Gera um relatório em PDF com estatísticas dos clubes.
        /// </summary>
        private void GerarPDFEstatisticas()
        {
            string caminhoPDF = @"EstatisticasClubes.pdf";

            try
            {
                Clubes campeao = DeterminarCampeao();
                if (campeao != null)
                {
                    campeao.Trofeus++;
                    SalvarDados(); 
                }

                using (var output = new FileStream(caminhoPDF, FileMode.Create))
                {
                    var doc = new Document(PageSize.A4.Rotate());
                    PdfWriter writer = PdfWriter.GetInstance(doc, output);
                    writer.PageEvent = new RodapePDF();
                    doc.Open();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        Properties.Resources.cinel.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        ms.Position = 0;
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ms);
                        logo.ScaleToFit(100f, 100f);
                        logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                        doc.Add(logo);
                    }
                    var fonteCabecalho = new iTextSharp.text.Font(
                        BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED),
                        12,
                        iTextSharp.text.Font.BOLD
                    );
                    var cabecalho = new Paragraph("\nDavid Gonçalves\nVersão 1.6\nData de hoje: " + DateTime.Now.ToShortDateString(), fonteCabecalho);
                    cabecalho.Alignment = Element.ALIGN_CENTER;
                    doc.Add(cabecalho);
                    doc.Add(new Paragraph("\n"));

                    if (campeao != null)
                    {
                        var fonteCampeao = new iTextSharp.text.Font(
                            BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED),
                            14,
                            iTextSharp.text.Font.BOLD
                        );
                        var resultadoCampeao = new Paragraph($"O campeão da liga é o {campeao.NomeClube}!", fonteCampeao);
                        resultadoCampeao.Alignment = Element.ALIGN_CENTER;
                        doc.Add(resultadoCampeao);
                        doc.Add(new Paragraph("\n"));
                    }

                    var clubesOrdenados = clubes.OrderByDescending(c => c.vitoriasCasa + c.vitoriasFora)
                                               .ThenBy(c => c.derrotas)
                                               .ThenByDescending(c => c.golosMarcados)
                                               .ThenByDescending(c => c.golosSofridos)
                                               .ToList();

                    PdfPTable tabelaEstatisticas = new PdfPTable(10);
                    tabelaEstatisticas.WidthPercentage = 100;

                    tabelaEstatisticas.AddCell("Clube");
                    tabelaEstatisticas.AddCell("Jogos Realizados");
                    tabelaEstatisticas.AddCell("Vitórias Casa");
                    tabelaEstatisticas.AddCell("Vitórias Fora");
                    tabelaEstatisticas.AddCell("Empates");
                    tabelaEstatisticas.AddCell("Derrotas");
                    tabelaEstatisticas.AddCell("Golos Marcados");
                    tabelaEstatisticas.AddCell("Golos Sofridos");
                    tabelaEstatisticas.AddCell("Classificação Geral");
                    tabelaEstatisticas.AddCell("Troféus");

                    foreach (Clubes clube in clubesOrdenados)
                    {
                        tabelaEstatisticas.AddCell(clube.NomeClube);
                        tabelaEstatisticas.AddCell(clube.jogosRealizados.ToString());
                        tabelaEstatisticas.AddCell(clube.vitoriasCasa.ToString());
                        tabelaEstatisticas.AddCell(clube.vitoriasFora.ToString());
                        tabelaEstatisticas.AddCell(clube.empates.ToString());
                        tabelaEstatisticas.AddCell(clube.derrotas.ToString());
                        tabelaEstatisticas.AddCell(clube.golosMarcados.ToString());
                        tabelaEstatisticas.AddCell(clube.golosSofridos.ToString());
                        tabelaEstatisticas.AddCell(clube.ClassificaoGeral.ToString());
                        tabelaEstatisticas.AddCell(clube.Trofeus.ToString());
                    }
                    doc.Add(tabelaEstatisticas);
                    doc.Close();
                }

                MessageBox.Show($"PDF criado com sucesso em: {caminhoPDF}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Erro de E/S ao aceder ao ficheiro PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado ao criar o ficheiro PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Classe interna para definir o rodapé do documento PDF.
        /// </summary>
        public class RodapePDF : PdfPageEventHelper
        {
            public override void OnStartPage(PdfWriter writer, Document document)
            {
                base.OnStartPage(writer, document);
                var rodapeFonte = new iTextSharp.text.Font(
                    BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED),
                    10,
                    iTextSharp.text.Font.NORMAL
                );

                PdfPTable rodape = new PdfPTable(1);
                rodape.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                PdfPCell celulaRodape = new PdfPCell(new Phrase("Página " + writer.PageNumber, rodapeFonte));
                celulaRodape.Border = 0;
                celulaRodape.HorizontalAlignment = Element.ALIGN_RIGHT;
                rodape.AddCell(celulaRodape);

                PdfPCell celulaInfo = new PdfPCell(new Phrase("Disciplina/UFCD UF5413 - Programação de Computadores - orientada a objetos", rodapeFonte));
                celulaInfo.Border = 0;
                celulaInfo.HorizontalAlignment = Element.ALIGN_LEFT;
                rodape.AddCell(celulaInfo);

                rodape.WriteSelectedRows(0, -1, document.LeftMargin, document.Bottom + 10, writer.DirectContent);
            }
        }

        /// <summary>
        /// Evento ao clicar no botão para gerar PDF.
        /// Invoca o método para gerar o relatório PDF de estatísticas dos clubes.
        /// </summary>
        private void btnPDF_Click(object sender, EventArgs e)
        {
            GerarPDFEstatisticas();

            Clubes campeao = DeterminarCampeao();
            if (campeao != null)
            {
                MessageBox.Show($"O campeão da liga é: {campeao.NomeClube}");
            }
            else
            {
                MessageBox.Show("Não há clubes na lista.");
            }
        }

        private void textBoxEstadio_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento ao clicar no botão de cancelar.
        /// Fecha o formulário atual.
        /// </summary>

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}