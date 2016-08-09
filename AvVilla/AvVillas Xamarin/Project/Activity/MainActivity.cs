using System;
using Android.App;
using Android.Content;
using System.Threading.Tasks;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Content.PM;

namespace Project
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait, WindowSoftInputMode = SoftInput.StateHidden)]
    public class MainActivity : AppCompatActivity
    {
        Button BotonAceptar;
        EditText TextoUsuario;
        EditText TextoContraseña;
        ProgressDialog progress;
        Android.App.AlertDialog.Builder alerta;
        string tipoDeCC;

        #region Lifecycle Implementation
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinner);
            TextoUsuario = FindViewById<EditText>(Resource.Id.TextoUsuario);
            TextoContraseña = FindViewById<EditText>(Resource.Id.TextoContraseña);
            BotonAceptar = FindViewById<Button>(Resource.Id.button1);

            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayShowTitleEnabled(false);
			SupportActionBar.SetHomeButtonEnabled(true);
			SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			SupportActionBar.SetDisplayShowTitleEnabled(false);

            Conexion_Web_Service.InitializeServiceClient();

            ArrayAdapter adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.Documentos_Array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;

            TextoUsuario.Text = "12";
            TextoContraseña.Text = "12";

            spinner.ItemSelected += spinner_ItemSelected;
            BotonAceptar.Click += BotonAceptar_Click;
            Conexion_Web_Service._client.VerificarUsuarioCompleted += _client_VerificarUsuarioCompleted;
        }
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			StartActivity(new Intent(Application.Context, typeof(Menu)));
			OverridePendingTransition(Android.Resource.Animation.SlideInLeft, Android.Resource.Animation.SlideOutRight);
			Finish();
			return true;
		}

        void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
			Spinner spinnerSelected = (Spinner)sender;
			tipoDeCC = Resources.GetStringArray(Resource.Array.Documentos_Value_Array)[spinnerSelected.SelectedItemPosition];
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnPause()
        {
            base.OnPause();
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
        }
        #endregion

        #region Events
        void BotonAceptar_Click(object sender, EventArgs e)
        {
            BotonAceptar.Enabled = false;
			if (string.IsNullOrWhiteSpace(TextoUsuario.Text))
            {
                alerta = HelperMethods.setAlert("Ingrese un Usuario", this);
                alerta.Show();
                BotonAceptar.Enabled = true;
                return;
            }

			if (string.IsNullOrWhiteSpace(TextoContraseña.Text))
            {
                alerta = HelperMethods.setAlert("Ingrese una Contraseña", this);
                alerta.Show();
                BotonAceptar.Enabled = true;
                return;
            }

			progress = HelperMethods.setSpinnerDialog("Iniciando Sesión...", this);
            Conexion_Web_Service._client.VerificarUsuarioAsync(tipoDeCC, TextoUsuario.Text, TextoContraseña.Text);
            progress.Show();
        }
        #endregion

        #region Method Completed
        async void _client_VerificarUsuarioCompleted(object sender, VerificarUsuarioCompletedEventArgs VerificarLoginCompleted)
        {
            await Task.Run(() => {
                if (VerificarLoginCompleted.Error != null)
                {
                    alerta = HelperMethods.setAlert(HelperMethods.problemaConexion, this);
                    RunOnUiThread(() => {
                        progress.Hide();
                        alerta.Show();
                        BotonAceptar.Enabled = true;
                    });
                }
                else
                {
                    if (VerificarLoginCompleted.Result != 0)
                    {
                        HelperMethods.logeado = true;
						HelperMethods.usuario_ID = VerificarLoginCompleted.Result;
						RunOnUiThread(() => {
							progress.Hide();
							StartActivity(new Intent(Application.Context, typeof(ConsultaActivity)));
							OverridePendingTransition(Android.Resource.Animation.SlideInLeft, Android.Resource.Animation.SlideOutRight);
							Finish();
				 		});
                    }
                    else
                    {
                        alerta = HelperMethods.setAlert("No es Bienvenido", this);
                        RunOnUiThread(() => {
                            progress.Hide();
                            alerta.Show();
                            BotonAceptar.Enabled = true;
                        });
                    }
                }
            });
        }
        #endregion
    }
}