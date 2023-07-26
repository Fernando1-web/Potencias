namespace Potencias;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    ///<Summary>
    ///<Createddate>24/07/2023</Createddate>
    ///<company>INDEL</company>
    ///<lastmodificationdate>24/07/2023</lastmodificationdate>
    ///<lastmodificationdescription>
    ///Este metodo permite calcular el cuadrado de un numero al presionar un boton designado
    ///
    ///</lastmodificationdescription>
    //////<lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    ///</Summary>
    private void BtnCalcularSquare_Clicked(object sender, EventArgs e)
    {
        double Cuadrado, Result1;

        Cuadrado = Convert.ToDouble(Entry1.Text);
        Result1 = Math.Pow(Cuadrado, 2);
        ResultadoCuadrado.Text = Result1.ToString();
    }

    ///<Summary>
    ///<Createddate>24/07/2023</Createddate>
    ///<company>INDEL</company>
    ///<lastmodificationdate>24/07/2023</lastmodificationdate>
    ///<lastmodificationdescription>
    ///Este metodo permite calcular el cubo de un numero al presionar un boton designado
    ///
    ///</lastmodificationdescription>
    //////<lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    ///</Summary>
    private void BtnCalcularCube_Clicked(object sender, EventArgs e)
    {
        double Cubo, Result2;

        Cubo = Convert.ToDouble(Entry2.Text);
        Result2 = Math.Pow(Cubo, 3);
        ResultadoCubo.Text = Result2.ToString();
    }

    ///<Summary>
    ///<Createddate>24/07/2023</Createddate>
    ///<company>INDEL</company>
    ///<lastmodificationdate>24/07/2023</lastmodificationdate>
    ///<lastmodificationdescription>
    ///Este metodo permite cerrar el programa al presionar un boton designado
    ///
    ///</lastmodificationdescription>
    //////<lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    ///</Summary>   
    
}

