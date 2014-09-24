using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace DragAndDrop
{
	[Activity (Label = "DragAndDrop", MainLauncher = true)]
	public class MainActivity : Activity
	{


		//Variables de Permisos
		List<Permisos_Activos> Permisos = new List<Permisos_Activos>();
		ListView lvPermisos;
		Adapter_Permisos adap_Permisos;

		//Variables de Permisos de Usuario
		List<Permisos_Activos> Permisos_Usuario = new List<Permisos_Activos>();
		ListView lvPermisos_Usuario;
		Adapter_Permisos adap_Permisos_Usuario;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//Definimos nuestra lista de Permisos
			Permisos.Add(new Permisos_Activos("GRAFICAR", "ic_2"));
			Permisos.Add(new Permisos_Activos("MAPA","ic_3"));
			Permisos.Add(new Permisos_Activos("CALENDARIO","ic_4"));

			/*****************************LISTVIEW PERMISOS (DERECHO)********************************************/
			//Inicializamos nuestro listview de permisos(listview de lado derecho)
			lvPermisos= FindViewById<ListView> (Resource.Id.lvPermisos);
			//Incializamos el adaptador con nuestro listado de permisos
			adap_Permisos=new Adapter_Permisos(this, Permisos);
			//Le asignamos el adaptador a nuestro listview
			lvPermisos.Adapter = adap_Permisos;
			//Definimos el evento ItemLongClick, este nos servira para cuando se realice un click prolongrado 
			//en uno de los items del listview se dispare nuestro arrastre del elemento
			lvPermisos.ItemLongClick += (s, args) => {
			
				//Inicializamos un objecto ClipData para saber en este caso la posicion del item que se esta arrastrando
				//y ademas a que listview pertece
				ClipData data = ClipData.NewPlainText ("Permisos", args.Position.ToString ());
				//Inicializamo nuestro ShadowBuilder para ver  el objecto que se esta arrastrando
				MyDragShadowBuilder my_shadown_screen = new MyDragShadowBuilder(args.View);
				//Asignamos los valores y arrancamos nuestro envento Drag
				args.View.StartDrag (data, my_shadown_screen, null, 0);
			
			};

			//Definimos el metodo que se dispara con el evento Drag de neustro listview.
			lvPermisos.Drag += (s, args) => 
			{

				switch (args.Event.Action) {
					//Se dispara cuando comienza el arrastrar algun elemento relazionado con la vista o esta misma
					case DragAction.Started:
					args .Handled = true;
					break;

					//Se dispara cuando una vista que esta siendo arrastranda entra en contacto en esta
					case DragAction.Entered:
					args.Handled = true;
					break;

					//Se dispara cuando una vista que esta siendo arrastranda sale en contacto en esta
					case DragAction.Exited:
					args.Handled = true;
					break;

					//Se dispara cuando una vista que esta siendo arrastrada es soltada dentro de esta
					case DragAction.Drop:
					args.Handled = true;
						//Verificamos que la vista que se solto viene de otro listview en este caso de Permisos_Usuario
						//de lo contrario no lo agregamos, ya que esto significa que la vista que se esta arrastrando se dejo soltar
						//dentro el elemento que la contiene(en este caso el listview al cual pertenece el elemento)
						if(args.Event.ClipDescription.Label.Equals("Permisos_Usuario"))
						{
							//Recupermos el index del elemento que se envio
							int posicion=int.Parse(args.Event.ClipData.GetItemAt(0).Text);
							//Recuperamos el objecto permiso del adapter del listview de donde procede la vista arrastrada
							//y lo agregamos al adapter del listview de donde se solto
							adap_Permisos.add(adap_Permisos_Usuario.PermisoBuscado(posicion));

							//Removemos el objecto permiso del adapter del listview de donde procede la vista arrastrada
							adap_Permisos_Usuario.remove (posicion);
						}

					break;

					//Se dispara cuando la operacion de arrastre ha terminado
					case DragAction.Ended:
					args.Handled = true;
					break;
				}


			};

			/*****************************LISTVIEW PERMISOS USUARIO(IZQUIERDO)********************************************/
			//Inicializamos nuestro listview de permisos(listview de lado izquierdo)
			lvPermisos_Usuario= FindViewById<ListView> (Resource.Id.lvPermisos_Usuario);
			//Incializamos el adaptador con nuestro listado de permisos de usuario, recordemos que este por defecto no 
			//tiene permisos asignados
			adap_Permisos_Usuario=new Adapter_Permisos(this, Permisos_Usuario);
			//Le asignamos el adaptador a nuestro listview
			lvPermisos_Usuario.Adapter = adap_Permisos_Usuario;

			//Definimos el evento ItemLongClick, este nos servira para cuando se realice un click prolongrado 
			//en uno de los items del listview se dispare nuestro arrastre del elemento
			lvPermisos_Usuario.ItemLongClick += (s, args) =>
			{
				//Inicializamos un objecto ClipData para saber en este caso la posicion del item que se esta arrastrando
				//y ademas a que listview pertece
				ClipData data = ClipData.NewPlainText ("Permisos_Usuario",args.Position.ToString());
				//Inicializamo nuestro ShadowBuilder para ver  el objecto que se esta arrastrando
				MyDragShadowBuilder my_shadown_screen = new MyDragShadowBuilder (args.View);
				//Asignamos los valores y arrancamos nuestro envento Drag
				args.View.StartDrag (data, my_shadown_screen, null, 0);

			};

			//Definimos el metodo que se dispara con el evento Drag de nuestro listview.
			lvPermisos_Usuario.Drag += (s, args) => 
			{

				switch (args.Event.Action) {
					//Se dispara cuando comienza el arrastrar algun elemento relazionado con la vista o esta misma
					case DragAction.Started:
					args .Handled = true;
					break;

					//Se dispara cuando una vista que esta siendo arrastranda entra en contacto en esta
					case DragAction.Entered:
					args.Handled = true;
					break;

					//Se dispara cuando una vista que esta siendo arrastranda sale en contacto en esta
					case DragAction.Exited:
					args.Handled = true;
					break;

					//Se dispara cuando una vista que esta siendo arrastrada es soltada dentro de esta
					case DragAction.Drop:
					args.Handled = true;
						//Verificamos que la vista que se solto viene de otro listview en este caso de Permisos
						//de lo contrario no lo agregamos, ya que esto significa que la vista que se esta arrastrando se dejo soltar
						//dentro el elemento que la contiene(en este caso el listview al cual pertenece el elemento)
						if(args.Event.ClipDescription.Label.Equals("Permisos"))
						{
							//Recupermos el index del elemento que se envio
							int posicion=int.Parse(args.Event.ClipData.GetItemAt(0).Text);
							//Recuperamos el objecto permiso del adapter del listview de donde procede la vista arrastrada
							//y lo agregamos al adapter del listview de donde se solto
							adap_Permisos_Usuario.add (adap_Permisos.PermisoBuscado(posicion));
							//Removemos el objecto permiso del adapter del listview de donde procede la vista arrastrada
							adap_Permisos.remove (posicion);
						}
					break;

					//Se dispara cuando la operacion de arrastre ha terminado
					case DragAction.Ended:
					args.Handled = true;
					break;
				}


			};


		}

		
		//Esta clase nos permitira crear vista del objecto(view) que estamos arrastrando
		private class MyDragShadowBuilder : View.DragShadowBuilder
		{
			//Definimos nuestro Drawable que nos va servir para dibujar
			private Drawable shadow;

			public MyDragShadowBuilder(View v): base (v)
			{
				/*
				//Inicializamos nuestro Drawable y le asignamos un color base
				shadow = new ColorDrawable(Color.LightSlateGray);
				*/

				//Habitilitamos el cache de la vista que estamos arrastrando
				v.DrawingCacheEnabled =true;
				//Recupermos un objecto bitmap, que es una imagen de nuestra vista que estamos arrastrando
				Bitmap bm = v.DrawingCache;
				//Ya que se tiene una imagen de la vista, procedemos a inicializar nuestro Drawable
				shadow = new BitmapDrawable(bm);
				//Y le asignamos un filtro de color para que se vea que hay una diferencia entre el objecto que se
				//arrastra con los demas
				shadow.SetColorFilter(Color.ParseColor("#4EB1FB") ,PorterDuff.Mode.Multiply);


			}

			public override void OnProvideShadowMetrics (Point size, Point touch)
			{
				//Obtenemos las dimenciones de nuestro vista(view) que estamos arrastrando
				int width = View.Width;
				int height = View.Height;
				//Le asignamos esas dimenciones a nuestro Drawable
				shadow.SetBounds (0, 0, width, height);
				//De igual forma establecemos las dimenciones de nuestro ShadownBuilder
				size.Set (width, height);

				//Definimos la posicion que se colocara nuestro ShadownBuilder cuando lo estemos arrastrando
				touch.Set(width/2, height/2);

			}

			public override void OnDrawShadow (Canvas canvas) 
			{
				base.OnDrawShadow (canvas);
				//Procedemos a cargar nuestro drawable en el ShadownBuilder
				shadow.Draw(canvas);
			}
		}

	}
}


