namespace ME_TelefonoP2;

public partial class MenuME : ContentPage
{

	public MenuME()
	{
		InitializeComponent();
	}
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        string numero = numeroTextBox.Text;
        string opcion = (opcionesComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
        string opcionesMultiples = "";
        foreach (ListBoxItem item in opcionesMultiplesListBox.SelectedItems)
        {
            opcionesMultiples += item.Content.ToString() + ", ";
        }

        MessageBoxResult result = MessageBox.Show($"¿Confirmar la recarga?\nNúmero: {numero}\nOpción: {opcion}\nOpciones múltiples: {opcionesMultiples}",
            "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);

        if (result == MessageBoxResult.Yes)
        {
            MessageBox.Show("La recarga fue exitosa.", "Recarga exitosa", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else
        {
            MessageBox.Show("La recarga fue cancelada.", "Recarga cancelada", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}

