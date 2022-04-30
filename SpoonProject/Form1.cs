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
            CreateReport(query, city);
        }
        catch (HttpRequestException)
        {
            Error.Visible = true;
        }
    }

    private void CreateReport(OpenWeatherAPI.QueryResponse query, string city)
    {
        int temp = (int)Math.Ceiling(query.Main.Temperature.KelvinCurrent / 100 - 273.15d);
        Temp.Text = $@"{temp} °C";
        TempF.Text = $@"{temp * 1.8 + 32} °F";
        Desc.Text = $@"{query.WeatherList[0].Main}, {query.WeatherList[0].Description}";
        CityDesc.Text = $@"{city}, {query.Sys.Country}";
        SetImage(query.WeatherList[0].Icon);
        Sunrise.Text = $@"Sunrise: {query.Sys.Sunrise.ToString("HH:mm")}";
        Sunset.Text = $@"Sunset: {query.Sys.Sunset.ToString("HH:mm")}";
        label2.Text = $@"ATM: {query.Main.Pressure}Pa";
        EnableFields();
    }

    private void EnableFields()
    {
        Temp.Visible = true;
        Picture.Visible = true;
        Desc.Visible = true;
        CityDesc.Visible = true;
        TempF.Visible = true;
        Sunrise.Visible = true;
        Sunset.Visible = true;
        groupBox1.Visible = true;
        groupBox2.Visible = true;
        groupBox3.Visible = true;
    }

    private void SetImage(string icon)
    {
        string url = $@"http://openweathermap.org/img/wn/{icon}@2x.png";
        Picture.Load(url);
    }
}