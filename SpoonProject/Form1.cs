namespace SpoonProject;

public partial class Anywheather : Form
{
    public Anywheather()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void Anywheather_Load(object sender, EventArgs e)
    {
        Date.Text = DateTime.Now.ToString().Split(' ')[0];
    }

    private void Enter_Click(object sender, EventArgs e)
    {
        var api = new OpenWeatherAPI.OpenWeatherApiClient("2c1a8c2ac1eba9e07589ae172b2063bb");
        Error.Visible = false;
        string city = City.Text;
        try
        {
            var query = api.Query(city);
            int temp = (int)Math.Ceiling(query.Main.Temperature.KelvinCurrent / 100 - 273.15d);
            Temp.Text = $@"{temp} °C";
            Desc.Text = $@"{query.WeatherList[0].Main}, {query.WeatherList[0].Description}";
            CityDesc.Text = city;
            EnableFields();
        }
        catch (HttpRequestException ex)
        {
            Error.Visible = true;
        }
    }

    private void EnableFields()
    {
        Temp.Visible = true;
        Picture.Visible = true;
        Desc.Visible = true;
        CityDesc.Visible = true;
    }
}