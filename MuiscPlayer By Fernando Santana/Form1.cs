using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using TagLib;

namespace MuiscPlayer_By_Fernando_Santana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            destravarBtns(false);
            checkRepetir.Checked = true;
        }
        Lista_Arquvios L = new Lista_Arquvios(); int id;
        string caminho = ""; bool play = false; PlayList p = new PlayList(); WindowsMediaPlayer musica; Random rnd = new Random(); int aux = 0;
        bool verificou = false; public int prox = 0; int ultima = 0; int total = 0; bool fim = false; List<int> tocadas = new List<int>(); int contador = 0;
        private void destravarBtns(bool T_or_F)
        {
            BtnAnterior.Enabled = T_or_F;
            BtnProxima.Enabled = T_or_F;
            BtnPrimeira.Enabled = T_or_F;
            BtnUltima.Enabled = T_or_F;
        }
        private void ProcurarMusicas(string caminho)
        {
            if (Directory.Exists(caminho)) //se existir o caminho...
            {
                foreach (string pathPasta in Directory.GetDirectories(caminho))//se existir pastas no diretorio, pegar diretorios
                {
                    ProcurarMusicas(pathPasta);
                }
                DirectoryInfo dir = new DirectoryInfo(caminho);
                foreach (FileInfo musica in dir.GetFiles("*.mp3*"))//musicas na pasta indicada pelo usuario
                {
                    Arquivo arq = new Arquivo(musica.Name, musica.FullName, Path.GetExtension(caminho), id);
                    L.AddUltimo(arq, id); //adicionar a musica na playlist 
                    var info = TagLib.File.Create(musica.FullName); //pegar informacoes da musica(duracao, bitrate...)
                                                                    // id  nome           local           album         duracao (.substring para deixar no formato 00:00, mm:ss)     bitRate
                    Musica m1 = new Musica(id, musica.Name, musica.FullName, info.Tag.Album, info.Properties.Duration.ToString().Substring(3, 5), info.Properties.AudioBitrate);
                    p.AddUltimo(m1, id); //adicionar a musica na playlist 
                    treeView1.Nodes.Add(musica.Name);                                             //adiciona nome da musica no treeview 
                    treeView1.Nodes[id].Nodes.Add("Duração: " + m1.Duracao);                      //adiciona as outras informacoes no treeview 
                    if (m1.Album != null) { treeView1.Nodes[id].Nodes.Add("Álbum: " + m1.Album); }//adiciona as outras informacoes no treeview 
                    else { treeView1.Nodes[id].Nodes.Add("Álbum: N/A"); }                         //adiciona as outras informacoes no treeview 
                    treeView1.Nodes[id].Nodes.Add("BitRate: " + m1.BitRate);                      //adiciona as outras informacoes no treeview 
                    treeView1.Nodes[id].Nodes.Add("Local: " + m1.Local);                          //adiciona as outras informacoes no treeview 
                    id++; //contador
                    total = id;
                }
            }
        }
        private void parar()
        {
            timer1.Stop();
            contador = 0; prox = 1; ultima = 0; fim = false; tocadas.Clear(); verificou = false; //zerar tudo
            musica.controls.stop();
            musica = null; //remove a musica 
            Image img = Image.FromFile(caminhoIcone + @"\Icones\Sem Título-5.png");
            BtnPlay.BackgroundImage = img;
        }
        private void tocarMusica(int nMusica)
        {
            prox = nMusica;
            p.PlayMusicas2(prox);
            tocadas.Add(prox);
            musica.URL = PlayList.localPlay;
            prox++;
        }
        private void voltar_btn_play()
        {
            Image img = Image.FromFile(caminhoIcone + @"\Icones\Sem Título-5.png");
            BtnPlay.BackgroundImage = img;
        }

        private void abirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog abrirPasta = new FolderBrowserDialog();
            if (abrirPasta.ShowDialog() == DialogResult.OK)
            {
                caminho = abrirPasta.SelectedPath; //pasta selecionada pelo usuario
                ProcurarMusicas(caminho);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkAleatoria.Checked) // modo aleatorio
            {
                if (musica != null)
                {
                    if (musica.status == "Parado" & verificou == false & tocadas.Count <= total & fim == false)
                    {
                        prox = rnd.Next(0, total);
                        if (!tocadas.Contains(prox) & musica.status == "Parado")
                        {
                            p.PlayMusicas2(prox);
                            verificou = true;
                            tocadas.Add(prox);
                            musica.URL = PlayList.localPlay;
                            contador++;
                        }
                    }
                    if (checkRepetir.Checked & tocadas.Count == total & fim != true & musica.status == "Parado") // "FINAL" CIRCULAR
                    {
                        verificou = false; tocadas.Clear(); fim = false; contador = 0; BtnAnterior.Enabled = true;
                        Console.WriteLine(Environment.NewLine + Environment.NewLine + "< FIM DA PLAYLIST...REINICIANDO... >" + Environment.NewLine + Environment.NewLine);
                    }
                    if (checkRepetir.Checked != true & tocadas.Count == total & fim != true & musica.status == "Parado")  //FINAL NAO CIRCULAR
                    {
                        MessageBox.Show("asgfeawpogjij");
                        Image img = Image.FromFile(@"C:\Users\ferna\Desktop\ICONES\green\Sem Título-5.png");
                        fim = true; parar(); tocadas.Clear(); fim = false; contador = 0; BtnAnterior.Enabled = true; BtnPlay.BackgroundImage = img;
                        Console.WriteLine(Environment.NewLine + Environment.NewLine + "< FIM DA PLAYLIST >" + Environment.NewLine + Environment.NewLine);
                    }
                    if (musica != null)
                    {
                        if (musica.status.Substring(0, 3) == "Rep" & musica.status != "Parado")
                        {
                            verificou = false;
                        }
                    }
                }
                else //PLAY INICIAL (DADO PELO USUARIO, O RESTO O PROGRAMA QUE FAZ)
                {
                    prox = rnd.Next(0, total);
                    if (!tocadas.Contains(prox) & musica == null)
                    {
                        Console.WriteLine(Environment.NewLine + "< INICIANDO PLAYLIST... >" + Environment.NewLine);
                        musica = new WindowsMediaPlayer();
                        p.PlayMusicas2(prox);
                        verificou = false;
                        fim = false;
                        tocadas.Add(prox);
                        musica.URL = PlayList.localPlay; //pega da playlist o local onde deve tocar a musica
                    }
                }
            }
            else //modo normal
            {
                if (musica != null)
                {
                    ultima = total; //-1 porque Ex. o total de musicas é 7, ou seja 1,2,3,4,5,6,7 mas o programa irá contar como 0,1,2,3,4,5,6
                    if (musica.status == "Parado" & verificou == false & prox < ultima & fim == false)
                    {
                        verificou = true;
                        p.PlayMusicas2(prox);
                        musica.URL = PlayList.localPlay;
                        prox++;
                    }
                    if (checkRepetir.Checked & prox == ultima & fim != true & musica.status == "Parado")         // "FINAL" CIRCULAR
                    {
                        verificou = false; prox = 0; fim = false;
                        Console.WriteLine(Environment.NewLine + Environment.NewLine + "< FIM DA PLAYLIST...REINICIANDO... >" + Environment.NewLine + Environment.NewLine);
                    }
                    if (checkRepetir.Checked == false & prox == ultima & fim != true & musica.status == "Parado") //FINAL NAO CIRCULAR
                    {
                        fim = true;
                        Image img = Image.FromFile(@"C:\Users\ferna\Desktop\ICONES\green\Sem Título-5.png");
                        BtnPlay.BackgroundImage = img;
                        Console.WriteLine(Environment.NewLine + Environment.NewLine + "< FIM DA PLAYLIST >" + Environment.NewLine + Environment.NewLine);
                    }
                    if (musica != null)
                    {
                        if (musica.status.Substring(0, 3) == "Rep") //analiza epanas as 3 primeiras letras da palavra("Rep" = "Reproduzindo")
                        {
                            verificou = false;
                        }
                    }
                }
                else if (musica == null)
                {
                    ultima = total; //-1 porque Ex. o total de musicas é 7, ou seja 1,2,3,4,5,6,7 mas o programa irá contar como 0,1,2,3,4,5,6
                    musica = new WindowsMediaPlayer();
                    p.PlayMusicas2(0);
                    musica.URL = PlayList.localPlay;
                    prox++;
                }
            }

        }
        string caminhoIcone = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.ToString());
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Image limpar = Image.FromFile(caminhoIcone + @"\Icones\Clear.png"); bool x = false;
            if (x == false)
            {
                BtnPlay.BackgroundImage = limpar;
                x = true;
            }
            if (caminho != "" & musica == null)              //BTN PLAY
            {
                Image img = Image.FromFile(caminhoIcone + @"\Icones\stop.png");

                BtnPlay.BackgroundImage = img;
                timer1.Dispose();
                destravarBtns(true);
                play = true;
                timer1.Start();

            }
            else if (play == true & musica != null)               //BTN PAUSE
            {
                Image img = Image.FromFile(caminhoIcone + @"\Icones\Sem Título-5.png");
                BtnPlay.BackgroundImage = img;
                musica.controls.pause();
                play = false;
            }
            else if (musica != null)
            {
                if (play == false & musica.status == "Em pausa") //BTN CONTINUE
                {
                    Image img = Image.FromFile(caminhoIcone + @"\Icones\stop.png");
                    BtnPlay.BackgroundImage = img;
                    play = true;
                    double tempo = musica.controls.currentPosition;
                    musica.controls.currentPosition = tempo;
                    musica.controls.play();
                }
            }
        } //BTN PLAY, PAUSE, CONTINUE

        private void Form1_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(caminhoIcone + @"\Icones\Sem Título-5.png");
            BtnPlay.BackgroundImage = img;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        } //SAIR

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (musica != null)
            {
                parar();
                voltar_btn_play();
            }
        }     //BTN STOP

        private void BtnProxima_Click(object sender, EventArgs e)
        {
            if (prox <= total & checkAleatoria.Checked != true)
            {
                p.PlayMusicas2(prox);
                tocadas.Add(prox);
                musica.URL = PlayList.localPlay;
                prox++;
            }
            else if (musica != null)                                                                             //FINAIS 
            {
                if (checkRepetir.Checked /*& prox == ultima */& fim != true & musica.status == "Pronto")         // "FINAL" CIRCULAR
                {
                    verificou = false; prox = 0; fim = false;
                    Console.WriteLine(Environment.NewLine + Environment.NewLine + "< FIM DA PLAYLIST...REINICIANDO... >" + Environment.NewLine + Environment.NewLine);
                }
                if (checkRepetir.Checked == false /*& prox == ultima */& fim != true & musica.status == "Pronto") //FINAL NAO CIRCULAR
                {
                    fim = true;
                    Image img = Image.FromFile(caminhoIcone + @"\Icones\Sem Título-5.png");
                    BtnPlay.BackgroundImage = img;
                    Console.WriteLine(Environment.NewLine + Environment.NewLine + "< FIM DA PLAYLIST >" + Environment.NewLine + Environment.NewLine);
                }
            }
            else if (prox >= total)
            {
                if (checkRepetir.Checked == false)
                {
                    if (MessageBox.Show("Todas as músicas já foram reproduzidas, deseja voltar ao início? ", "Deseja voltar? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        parar();
                    }
                }
            }
            if (prox < total & checkAleatoria.Checked)
            {
                bool parar = false;
                while (tocadas.Contains(prox) & parar == false & tocadas.Count < total)
                {
                    prox = rnd.Next(0, total);
                    if (!tocadas.Contains(prox))
                    {
                        parar = true;
                        p.PlayMusicas2(prox);
                        musica.URL = PlayList.localPlay;
                        tocadas.Add(prox);
                    }
                }
            }
        }  //BTN PROX

        private void BtnUltima_Click(object sender, EventArgs e)      //BTN ULTIMA
        {
           
            if (musica != null)
            {
                if (musica.status != "Parado")
                {
                    tocarMusica(total - 1);
                }
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (prox >= 2 & checkAleatoria.Checked == false)
            {
                aux++;
                prox -= 2;
                p.PlayMusicas2(prox);
                musica.URL = PlayList.localPlay;
                prox++;
            }
            if (tocadas.Count > 0 & checkAleatoria.Checked & prox >= aux & prox >= 0)//voltar pra 2
            {
                aux++;
                prox = tocadas.Count;
                prox -= aux; // prox => 2 , prox => 3...
                p.PlayMusicas2(tocadas[prox]);
                musica.URL = PlayList.localPlay;
                prox++;
            }
            else if (aux > prox & checkAleatoria.Checked == false)
            {
                aux = 1;
            }
            else if (prox < 0)
            {
                aux = 0;
                prox = tocadas.Count;
            }
        }  //BTN ANTERIOR

        private void BtnPrimeira_Click(object sender, EventArgs e)     //BTN PRIMEIRA
        {
            if (musica != null)
            {
                if (musica.status != "Parado")
                {
                    tocarMusica(0);
                }
            }
        }
    }
}
