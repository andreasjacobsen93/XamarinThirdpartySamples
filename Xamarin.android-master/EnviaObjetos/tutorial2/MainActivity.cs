using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace tutorial2
{
	[Activity (Label = "tutorial2", MainLauncher = true)]
	public class MainActivity : Activity
	{
	

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button libro1 = FindViewById<Button> (Resource.Id.btnLibro1);
			
			libro1.Click += delegate {
				var libro = new cls_Libro(1,"EL CODIGO DA VINCI","DAN BROWN",480, "Antes de morir asesinado, Jacques Sauniére, el último Gran Maestre de una sociedad secreta que se remonta a la fundación de los Templarios, transmite a su nieta Sophie una misteriosa clave. Sauniére y sus predecesores, entre los que se encontraban hombres como Isaac Newton o Leonardo Da Vinci, han conservado durante siglos un conocimiento que puede cambiar completamente la historia de la humanidad. Ahora Sophie, con la ayuda del experto en simbología Robert Langdon, comienza la búsqueda de ese secreto, en una trepidante carrera que les lleva de una clave a otra, descifrando mensajes ocultos en los más famosos cuadros del genial pintor y en las paredes de antiguas catedrales.");

				// Goto NextActivity
				var intent = new Intent(this, typeof(Main2));
				intent.PutExtra("libro_enviado", libro); // intent に Card を詰める

				this.StartActivity(intent);
			};


			Button libro2 = FindViewById<Button> (Resource.Id.btnLibro2);

			libro2.Click += delegate {
				var libro = new cls_Libro(2,"INFIERNO","DAN BROWN",580, "EN EL CORAZÓN DE ITALIA, EL CATEDRÁTICO DE SIMBOLOGÍA DE HARVARD ROBERT LANGDON SE VE ARRASTRADO A UN MUNDO TERRORÍFICO CENTRADO EN UNA DE LAS OBRAS MAESTRAS DE LA LITERATURA MÁS IMPERECEDERAS Y MISTERIOSAS DE LA HISTORIA: EL INFIERNO DE DANTE.\n\nCON ESTE TELÓN DE FONDO, LANGDON SE ENFRENTA A UN ADVERSARIO ESCALOFRIANTE Y LIDIA CON UN ACERTIJO INGENIOSO EN UN ESCENARIO DE ARTE CLÁSICO, PASADIZOS SECRETOS Y CIENCIA FUTURISTA. APOYÁNDOSE EN EL OSCURO POEMA ÉPICO DE DANTE, LANGDON, EN UNA CARRERA CONTRARRELOJ, BUSCA RESPUESTAS Y PERSONAS DE CONFIANZA ANTES DE QUE EL MUNDO CAMBIE IRREVOCABLEMENTE.");

				// Goto NextActivity
				var intent = new Intent(this, typeof(Main2));
				intent.PutExtra("libro_enviado", libro); // intent に Card を詰める

				this.StartActivity(intent);
			};
		}
	}
}


