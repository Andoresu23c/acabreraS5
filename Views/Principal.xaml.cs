using acabreraS5.Models;

namespace acabreraS5.Views;

public partial class Principal : ContentPage
{
	public Principal()
	{
		InitializeComponent();
	}

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
        statusMessage.Text = "";
        App.personRepo.addNewPerson(txtNombre.Text);
        statusMessage.Text = App.personRepo.StatusMessage;
    }

    private void btnObtener_Clicked(object sender, EventArgs e)
    {
        statusMessage.Text = "";

        List<Persona> person = App.personRepo.GetAllPerson();
        listarPersona.ItemsSource = person;
        statusMessage.Text = App.personRepo.StatusMessage;
    }
}