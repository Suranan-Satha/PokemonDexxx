namespace POkemonDExx
{

    public partial class Form1 : Form
    {
        private Dictionary<string, Pokemon> pokemonDict = new Dictionary<string, Pokemon>();

        public Form1()
        {
            InitializeComponent();
            LoadPokemonList();
        }

        private void LoadPokemonList()
        {
            pokemonDict["Pikachu"] = new Pikachu();
            pokemonDict["Snorlax"] = new Snorlax();
            pokemonDict["Slaking"] = new Slaking();
            pokemonDict["Drowzee"] = new Drowzee();
            pokemonDict["Gengar"] = new Gengar();
            pokemonDict["Arbok"] = new Arbok();

            displayPokemon(pokemonDict["Pikachu"]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void displayPokemon(Pokemon pokemon)
        {
            lbPokemon.Text = pokemon.getName();
            lbType.Text = pokemon.getType();
            lb_Hp.Text = pokemon.getHP().ToString();
            lb_Atk.Text = pokemon.getAttack().ToString();
            lb_Def.Text = pokemon.getDefense().ToString();
            lb_SplAtk.Text = pokemon.getSpecialAttack().ToString();
            lb_SplDef.Text = pokemon.getSpecialDefense().ToString();
            lb_Sp.Text = pokemon.getSpeed().ToString();
            lb_Total.Text = pokemon.getTotal().ToString();
            lb_H.Text = pokemon.getHeight().ToString() + " m";
            lb_W.Text = pokemon.getWeight().ToString() + " kg";

            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }



        }

        private void btnSnorlax_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Snorlax"]);

        private void btnPikachu_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Pikachu"]);

        private void btnSlaking_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Slaking"]);

        private void btnDrowzee_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Drowzee"]);

        private void btnGengar_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Gengar"]);

        private void btnArbok_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Arbok"]);

    }
}
