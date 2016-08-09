using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Android.Provider;
using Android.Content.PM;
using Environment = Android.OS.Environment;
using Uri = Android.Net.Uri;
using System.IO;
using System.Threading.Tasks;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Graphics.Drawables;
using Android.Content.Res;
using ZXing.Mobile;


namespace Project
{
	// ScreenOrientation Block activity of rotation user, ConfigurationChanges block activity of system intent like gallery and camera
    [Activity(ScreenOrientation = ScreenOrientation.Portrait, WindowSoftInputMode = SoftInput.StateHidden, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class ConsultaActivity : AppCompatActivity
    {
		Button BotonEnviar;
        Button BotonFotoUno;
        Button BotonFotoDos;
		Button AgregarFotoUno;
		Button AgregarFotoDos;
        EditText Nombres;
        EditText Apellidos;
        EditText Documento;
        ImageView imageViewFotoUno;
        ImageView imageViewFotoDos;
		TextView fechaNacimiento;
		Spinner spinnerTipoDocumento;
        ProgressDialog progress;
        Android.App.AlertDialog.Builder alerta;
		Java.IO.File _file;
		Java.IO.File _dir;
		Bitmap bitmapUno;
		Bitmap bitmapDos;
        string tipoDeCC;
        string sexo;
        bool fotoUno;
		bool fotoUnoAsignada;
		bool fotoDosAsignada;

        #region Lifecycle Implementation
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Consulta);


            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			Spinner spinnerSexo = FindViewById<Spinner>(Resource.Id.spinnerSexo);
            spinnerTipoDocumento = FindViewById<Spinner>(Resource.Id.spinnerTipoDocumento);
            BotonEnviar = FindViewById<Button>(Resource.Id.btnEnviar);
            BotonFotoUno = FindViewById<Button>(Resource.Id.btnBorrarUno);
            BotonFotoDos = FindViewById<Button>(Resource.Id.btnBorrarDos);
			AgregarFotoUno = FindViewById<Button>(Resource.Id.AgregarFotoUno);
			AgregarFotoDos = FindViewById<Button>(Resource.Id.AgregarFotoDos);
            imageViewFotoUno = FindViewById<ImageView>(Resource.Id.imageView1);
            imageViewFotoDos = FindViewById<ImageView>(Resource.Id.imageView2);

			fechaNacimiento = FindViewById<TextView>(Resource.Id.FechaInicial);
			Nombres = FindViewById<EditText>(Resource.Id.TextNombres);
			Apellidos = FindViewById<EditText>(Resource.Id.TextApellidos);
			Documento = FindViewById<EditText>(Resource.Id.TextDocumento);

			SetSupportActionBar(toolbar);
			Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
			SupportActionBar.SetHomeButtonEnabled(true);
			SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			SupportActionBar.SetDisplayShowTitleEnabled(false);

            ArrayAdapter adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.Documentos_Array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerTipoDocumento.Adapter = adapter;
            adapter = null;

            adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.Sexo_Array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerSexo.Adapter = adapter;

            #region Calendario
            // Invoca el fragmento que contiene el calendario de fecha inicial
            var fragTx = FragmentManager.BeginTransaction();
            var frag = new DatePickerFragment();
            fragTx.Add(Resource.Id.fragment_Fecha_Inicial, frag);
			fragTx.Commit();
			#endregion

			if (IsThereAnAppToTakePictures())
			{
				CreateDirectoryForPictures();
			}
			else
			{
				alerta = HelperMethods.setAlert("Problemas con la camara del dispositivo", this);
				alerta.Show();
			}

			MobileBarcodeScanner.Initialize(this.Application);

			imageViewFotoUno.Click += imageViewFoto_Click;
			imageViewFotoDos.Click += imageViewFoto_Click;
            spinnerTipoDocumento.ItemSelected += spinnersAmbos_ItemSelected;
            spinnerSexo.ItemSelected += spinnersAmbos_ItemSelected;
            BotonFotoUno.Click += TakeAPicture;
            BotonFotoDos.Click += TakeAPicture;
			BotonEnviar.Click += async(sender, e) => //BotonEnviar_Click;
			{	

				var scanner = new ZXing.Mobile.MobileBarcodeScanner();
				var result = await scanner.Scan();

				if (result != null)
					alerta = HelperMethods.setAlert(result.Text, this);
					Console.WriteLine("Scanned Barcode: " + result.Text);
			};
			AgregarFotoUno.Click += BotonAgregar_Click;
			AgregarFotoDos.Click += BotonAgregar_Click;
            Conexion_Web_Service._client.GuardarPeticionCompleted += _client_GuardarPeticionCompleted;
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }

        protected override void OnPause()
        {
            base.OnPause();
        }

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			HelperMethods.logeado = false;
			HelperMethods.usuario_ID = 0;
			StartActivity(new Intent(Application.Context, typeof(MainActivity)));
			OverridePendingTransition(Android.Resource.Animation.SlideInLeft, Android.Resource.Animation.SlideOutRight);
			Finish();
			return true;
		}

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
        }
        #endregion

        #region Events
		#region Spinner Event
		void spinnersAmbos_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinnerSelected = (Spinner)sender;

			if (spinnerSelected == spinnerTipoDocumento)
			{
				tipoDeCC = Resources.GetStringArray(Resource.Array.Documentos_Value_Array)[spinnerSelected.SelectedItemPosition];
			}
			else
			{
				sexo = Resources.GetStringArray(Resource.Array.Sexo_Value_Array)[spinnerSelected.SelectedItemPosition];
			}
        }
		#endregion

        #region Evento Botones
        void TakeAPicture(object sender, EventArgs eventArgs)
        {
            if (sender == BotonFotoUno)
            {
                fotoUno = true;
            }
            else
            {
                fotoUno = false;
            }

            Intent intent = new Intent(MediaStore.ActionImageCapture);

            _file = new Java.IO.File(_dir, string.Format("miFoto{0}.jpg", Guid.NewGuid()));

            intent.PutExtra(MediaStore.ExtraOutput, Uri.FromFile(_file));

            StartActivityForResult(intent, 0);
        }

		void BotonAgregar_Click(object sender, EventArgs eventArgs)
		{
			if (sender == AgregarFotoUno)
			{
				fotoUno = true;
			}
			else
			{
				fotoUno = false;
			}

			var imageIntent = new Intent();

			imageIntent.SetType("image/*");
			imageIntent.SetAction(Intent.ActionGetContent);
			StartActivityForResult(
				Intent.CreateChooser(imageIntent, "Select photo"), 10);
		}

        async void BotonEnviar_Click(object sender, EventArgs e)
        {
			if (!ValidarCampos())
			{
				alerta = HelperMethods.setAlert("Faltan campos por llenar", this);
				alerta.Show();
				return;
			}

			progress = HelperMethods.setSpinnerDialog("Cargando Informacion...", this);
			progress.Show();

			await Task.Run(() => { 
				byte[] primeraFotoBytes = null;
				byte[] segundaFotoBytes = null;
				string observaciones;
				EditText observacionesCampo = FindViewById<EditText>(Resource.Id.editObservaciones);

				if (string.IsNullOrWhiteSpace(observacionesCampo.Text))
				{
					observaciones = "";
				}
				else
				{
					observaciones = observacionesCampo.Text;
				}

				if (fotoUnoAsignada)
				{
					using (MemoryStream stream = new MemoryStream())
					{
						bitmapUno.Compress(Bitmap.CompressFormat.Jpeg, 50, stream);
						primeraFotoBytes = stream.ToArray();
					}
				}

				if (fotoDosAsignada)
				{
					using (MemoryStream stream = new MemoryStream())
					{
						bitmapDos.Compress(Bitmap.CompressFormat.Jpeg, 50, stream);
						segundaFotoBytes = stream.ToArray();
					}
				}
					
				Conexion_Web_Service._client.GuardarPeticionAsync(Nombres.Text, Apellidos.Text, HelperMethods.ConvertToUnixTimestamp(DatePickerFragment.date), sexo, tipoDeCC, int.Parse(Documento.Text), observacionesCampo.Text, primeraFotoBytes, segundaFotoBytes, HelperMethods.usuario_ID);
        	});
		}

		void imageViewFoto_Click(object sender, EventArgs e)
		{
			var imagen = (ImageView)sender;
			View vistaModal = LayoutInflater.Inflate(Resource.Layout.Modal, null);
			ImageView imagenModal = vistaModal.FindViewById<ImageView>(Resource.Id.imageViewModal);

			if (imagen == imageViewFotoUno && fotoUnoAsignada == true)
			{
				imagenModal.SetImageBitmap(bitmapUno);
			}
			else if(imagen == imageViewFotoDos && fotoDosAsignada == true)
			{
				imagenModal.SetImageBitmap(bitmapDos);
			}
			else
			{
				return;
			}

			Android.App.AlertDialog.Builder ventanaModalAlert = new Android.App.AlertDialog.Builder(this);
			ventanaModalAlert.SetView(vistaModal);
			ventanaModalAlert.SetNegativeButton("Aceptar", delegate { });
			ventanaModalAlert.SetPositiveButton("Borrar Foto", delegate 
			{
				imagen.SetImageBitmap(null);
				if (imagen == imageViewFotoUno)
				{
					fotoUnoAsignada = false;
					bitmapUno = null;
				}
				else
				{
					fotoDosAsignada = false;
					bitmapDos = null;
				}
				GC.Collect();
			});
			ventanaModalAlert.Create().Show();
		}
		#endregion

		#region Camera Result
		protected async override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
			BitmapFactory.Options options;
			Bitmap bitmapTemporal;

			if (Result.Ok != resultCode)
			{
				return;
			}

			if (requestCode == 10)
			{
				options = GetBitmapOptionsOfImage();
				using (bitmapTemporal = await LoadScaledDownBitmapForDisplayAsync(GetPathToImage(data.Data), options, 150, 150))
				{
					if (fotoUno)
					{
						bitmapUno = bitmapTemporal;
						imageViewFotoUno.SetImageBitmap(bitmapUno);
						fotoUnoAsignada = true;
					}
					else
					{
						bitmapDos = bitmapTemporal;
						imageViewFotoDos.SetImageBitmap(bitmapDos);
						fotoDosAsignada = true;
					}
					return;
				}
			}

			// Make it available in the gallery
			Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
            Uri contentUri = Uri.FromFile(_file);
            mediaScanIntent.SetData(contentUri);
            SendBroadcast(mediaScanIntent);

			// Display in ImageView. We will resize the bitmap to fit the display
			// Loading the full sized image will consume to much memory 
			// and cause the application to crash.
			options = GetBitmapOptionsOfImage();				
			using (bitmapTemporal = await LoadScaledDownBitmapForDisplayAsync(_file.Path, options, 150, 150))
			{
				if (bitmapTemporal != null)
				{
					if (fotoUno)
					{
						bitmapUno = bitmapTemporal;
						imageViewFotoUno.SetImageBitmap(bitmapUno);
						fotoUnoAsignada = true;
					}
					else
					{
						bitmapDos = bitmapTemporal;
						imageViewFotoDos.SetImageBitmap(bitmapDos);
						fotoDosAsignada = true;
					}
				}
            }
        }
        #endregion

        #region Method Completed
        async void _client_GuardarPeticionCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            await Task.Run(() => { 
                if (e.Error == null)
                {
                    alerta = HelperMethods.setAlert("Informacion Cargada", this);
                    RunOnUiThread(() =>
                    {
                        progress.Hide();
                        alerta.Show();
                    });
                }
                else
                {
                    alerta = HelperMethods.setAlert(HelperMethods.problemaConexion, this);
                    RunOnUiThread(() =>
                    {
                        progress.Hide();
                        alerta.Show();
                    });
                }
            });
        }
        #endregion
        #endregion

        #region HelperMethods
        void CreateDirectoryForPictures()
        {
            _dir = new Java.IO.File(
                Environment.GetExternalStoragePublicDirectory(
                    Environment.DirectoryPictures), "BancoFolder");
            if (!_dir.Exists())
            {
                _dir.Mkdirs();
            }
        }

        bool IsThereAnAppToTakePictures()
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            IList<ResolveInfo> availableActivities =
                PackageManager.QueryIntentActivities(intent, PackageInfoFlags.MatchDefaultOnly);
            return availableActivities != null && availableActivities.Count > 0;
        }

		bool ValidarCampos()
		{
			if (!string.IsNullOrWhiteSpace(Nombres.Text) && !string.IsNullOrWhiteSpace(Apellidos.Text) && !string.IsNullOrWhiteSpace(Documento.Text) && !string.IsNullOrWhiteSpace(DatePickerFragment.dateString) && (fotoUnoAsignada || fotoDosAsignada))
			{
				return true;
			}
			return false;
		}

		async Task<Bitmap> LoadScaledDownBitmapForDisplayAsync(string filename, BitmapFactory.Options options, int reqWidth, int reqHeight)
		{
			// Calculate inSampleSize
			options.InSampleSize = CalculateInSampleSize(options, reqWidth, reqHeight);

			// Decode bitmap with inSampleSize set
			options.InJustDecodeBounds = false;

			return await BitmapFactory.DecodeFileAsync(filename, options);
		}

		int CalculateInSampleSize(BitmapFactory.Options options, int reqWidth, int reqHeight)
		{
			// Raw height and width of image
			float height = options.OutHeight;
			float width = options.OutWidth;
			double inSampleSize = 1D;

			if (height > reqHeight || width > reqWidth)
			{
				int halfHeight = (int)(height / 2);
				int halfWidth = (int)(width / 2);

				// Calculate a inSampleSize that is a power of 2 - the decoder will use a value that is a power of two anyway.
				while ((halfHeight / inSampleSize) > reqHeight && (halfWidth / inSampleSize) > reqWidth)
				{
					inSampleSize *= 2;
				}
			}

			return (int)inSampleSize;
		}

		BitmapFactory.Options GetBitmapOptionsOfImage()
		{
			BitmapFactory.Options options = new BitmapFactory.Options
			{
				InJustDecodeBounds = true
			};

			int imageHeight = options.OutHeight;
			int imageWidth = options.OutWidth;

			return options;
		}

		string GetPathToImage(Android.Net.Uri uri)
		{
			string doc_id = "";
			using (var c1 = ContentResolver.Query(uri, null, null, null, null))
			{
				c1.MoveToFirst();
				String document_id = c1.GetString(0);
				doc_id = document_id.Substring(document_id.LastIndexOf(":") + 1);
			}

			string path = null;

			// The projection contains the columns we want to return in our query.
			string selection = Android.Provider.MediaStore.Images.Media.InterfaceConsts.Id + " =? ";
			using (var cursor = ContentResolver.Query(MediaStore.Images.Media.ExternalContentUri, null, selection, new string[] { doc_id }, null))
			{
				if (cursor == null) return path;
				var columnIndex = cursor.GetColumnIndexOrThrow(MediaStore.Images.Media.InterfaceConsts.Data);
				cursor.MoveToFirst();
				path = cursor.GetString(columnIndex);
			}
			return path;
		}
		#endregion
	}
}