
// This file has been generated by the GUI designer. Do not modify.
namespace View
{
	public partial class GUI
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Label label_top_menu;
		
		private global::Gtk.Button button_input_program;
		
		private global::Gtk.Button button_complete_eval;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Button button_debug_eval;
		
		private global::Gtk.Button button_input_default;
		
		private global::Gtk.Button button_ser_to_file;
		
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.Button button_ser_from_file;
		
		private global::Gtk.Button button_save_to_file;
		
		private global::Gtk.Button button_exit;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget View.GUI
			this.Name = "View.GUI";
			this.Title = global::Mono.Unix.Catalog.GetString ("GUI");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			// Container child View.GUI.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label_top_menu = new global::Gtk.Label ();
			this.label_top_menu.Name = "label_top_menu";
			this.label_top_menu.LabelProp = global::Mono.Unix.Catalog.GetString ("--- Toy Interpreter ---");
			this.label_top_menu.WidthChars = 22;
			this.vbox2.Add (this.label_top_menu);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label_top_menu]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.button_input_program = new global::Gtk.Button ();
			this.button_input_program.CanFocus = true;
			this.button_input_program.Name = "button_input_program";
			this.button_input_program.UseUnderline = true;
			this.button_input_program.Label = global::Mono.Unix.Catalog.GetString ("Input Program");
			this.vbox2.Add (this.button_input_program);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.button_input_program]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.button_complete_eval = new global::Gtk.Button ();
			this.button_complete_eval.CanFocus = true;
			this.button_complete_eval.Name = "button_complete_eval";
			this.button_complete_eval.UseUnderline = true;
			this.button_complete_eval.Label = global::Mono.Unix.Catalog.GetString ("Complete Eval");
			this.vbox2.Add (this.button_complete_eval);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.button_complete_eval]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.button_debug_eval = new global::Gtk.Button ();
			this.button_debug_eval.CanFocus = true;
			this.button_debug_eval.Name = "button_debug_eval";
			this.button_debug_eval.UseUnderline = true;
			this.button_debug_eval.Label = global::Mono.Unix.Catalog.GetString ("Debug Eval");
			this.vbox3.Add (this.button_debug_eval);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.button_debug_eval]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.button_input_default = new global::Gtk.Button ();
			this.button_input_default.CanFocus = true;
			this.button_input_default.Name = "button_input_default";
			this.button_input_default.UseUnderline = true;
			this.button_input_default.Label = global::Mono.Unix.Catalog.GetString ("Input Default Program");
			this.vbox3.Add (this.button_input_default);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.button_input_default]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.button_ser_to_file = new global::Gtk.Button ();
			this.button_ser_to_file.CanFocus = true;
			this.button_ser_to_file.Name = "button_ser_to_file";
			this.button_ser_to_file.UseUnderline = true;
			this.button_ser_to_file.Label = global::Mono.Unix.Catalog.GetString ("Serialize to file");
			this.vbox3.Add (this.button_ser_to_file);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.button_ser_to_file]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox3]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.button_ser_from_file = new global::Gtk.Button ();
			this.button_ser_from_file.CanFocus = true;
			this.button_ser_from_file.Name = "button_ser_from_file";
			this.button_ser_from_file.UseUnderline = true;
			this.button_ser_from_file.Label = global::Mono.Unix.Catalog.GetString ("Serialize from File");
			this.vbox4.Add (this.button_ser_from_file);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.button_ser_from_file]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.button_save_to_file = new global::Gtk.Button ();
			this.button_save_to_file.CanFocus = true;
			this.button_save_to_file.Name = "button_save_to_file";
			this.button_save_to_file.UseUnderline = true;
			this.button_save_to_file.Label = global::Mono.Unix.Catalog.GetString ("Save content to File");
			this.vbox4.Add (this.button_save_to_file);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.button_save_to_file]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.button_exit = new global::Gtk.Button ();
			this.button_exit.CanFocus = true;
			this.button_exit.Name = "button_exit";
			this.button_exit.UseUnderline = true;
			this.button_exit.BorderWidth = ((uint)(24));
			this.button_exit.Label = global::Mono.Unix.Catalog.GetString ("Exit");
			this.vbox4.Add (this.button_exit);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.button_exit]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			this.vbox1.Add (this.vbox4);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox4]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 303;
			this.Show ();
			this.button_input_program.Clicked += new global::System.EventHandler (this.OnButtonInputProgramClicked);
			this.button_complete_eval.Clicked += new global::System.EventHandler (this.OnButtonCompleteEvalClicked);
			this.button_debug_eval.Clicked += new global::System.EventHandler (this.OnButtonDebugEvalClicked);
			this.button_input_default.Clicked += new global::System.EventHandler (this.OnButtonInputDefaultClicked);
			this.button_ser_to_file.Clicked += new global::System.EventHandler (this.OnButtonSerToFileClicked);
			this.button_ser_from_file.Clicked += new global::System.EventHandler (this.OnButtonSerFromFileClicked);
			this.button_save_to_file.Clicked += new global::System.EventHandler (this.OnButtonSaveToFileClicked);
			this.button_exit.Clicked += new global::System.EventHandler (this.OnButtonExitClicked);
		}
	}
}