using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Parse;
using System.Threading.Tasks;

namespace ParseAndroidStarterProject
{
	[Activity (Label = "EditarActivity")]			
	public class EditarActivity : Activity
	{
		//VARIABLES DE NUESTROS ELEMENTOS DEL LAYOUT
		Button btnActualizar;
		Button btnBorrar;
		EditText txtNombre;
		EditText txtTelefono;

		//OBJECTO TEMPORAL ParseObject
		ParseObject contacto;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.editar_contacto);
					
			//INICIALIZAMOS NUESTROS ELEMENTOS
			btnActualizar = FindViewById<Button> (Resource.Id.btnActualizar);
			btnBorrar = FindViewById<Button> (Resource.Id.btnBorrar);
			txtNombre = FindViewById<EditText> (Resource.Id.txtNombre);
			txtTelefono = FindViewById<EditText> (Resource.Id.txtTelefono);


			//CONFIGURAMOS EL BOTON DE ACTUALIZAR
			btnActualizar.Click += delegate {
				//VERIFICAMOS QUE NUESTRO CONTACTO NO SE NULL
				if(contacto !=null)
				{
					//TOMAMOS NUESTRO CONTACTO Y LE ASIGNAMOS LOS NUEVOS VALORES
					contacto["nombre"] =txtNombre.Text;
					contacto["telefono"] = txtTelefono.Text;

					//LLAMAMOS EL METODO SaveAsync PARA GUARDAR LOS CAMBIOS
					contacto.SaveAsync ();

					Toast.MakeText (this, "Se actualizo el registro", ToastLength.Long).Show();
				}else{

					Toast.MakeText (this, "No hay objecto para actualizar", ToastLength.Long).Show();
				}
			};


			//CONFIGURAMOS EL BOTON DE BORRAR
			btnBorrar.Click += delegate {
				//VERIFICAMOS QUE NUESTRO CONTACTO NO SE NULL
				if(contacto !=null)
				{
					//PARA BORRAR SOLAMENTE LLAMAMOS AL METODO DeleteAsync DE NEUSTRO OBJECTO
					contacto.DeleteAsync();


					Toast.MakeText (this, "Se elimino el registro", ToastLength.Long).Show();
					contacto=null;
					txtNombre.Text="";
					txtTelefono.Text="";
				}else{

					Toast.MakeText (this, "No hay objecto para eliminar", ToastLength.Long).Show();
				}
			};

			//RECUPERAMOS EL ID DE NUESTRO CONTACTO
			string id = Intent.GetStringExtra ("id") ?? "0";

			//LLAMAMOS AL METODO BuscaContacto Y LE PASAMOS EL ID DEL CONTACTO QUE DESEAMOS MODIFICAR
			BuscaContacto (id);
		}


		public async Task BuscaContacto (string id)
		{
			//LLAMAMOS AL METODO GetQuery DEL ParseObject, Y LE PASAMOS EL ID DEL CONTACTO A BUSCAR
			var query = ParseObject.GetQuery ("Contacto").WhereEqualTo("objectId", id);
			IEnumerable<ParseObject> results = await query.FindAsync ();

			//VERIFICAMOS QUE SI SE ENCONTRARON CONTACTOS
			if (results.ToList ().Count > 0) {
				//SI ES ASI, LE ASIGNAMOS LOS VALORES A LOS ELEMENTOS DE NUESTRO LAYOUT
				contacto = results.ToList ()[0];
				txtNombre.Text=contacto.Get<string>("nombre");
				txtTelefono.Text=contacto.Get<string>("telefono");
			} else {
				Toast.MakeText (this, "No se encontro el contacto", ToastLength.Long).Show();
			}


		}

	}
}

