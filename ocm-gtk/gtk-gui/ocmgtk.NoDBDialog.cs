// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ocmgtk {
    
    
    public partial class NoDBDialog {
        
        private Gtk.HBox hbox1;
        
        private Gtk.Image image30;
        
        private Gtk.Label label1;
        
        private Gtk.Button button268;
        
        private Gtk.Button button267;
        
        private Gtk.Button button269;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.NoDBDialog
            this.Name = "ocmgtk.NoDBDialog";
            this.Title = Mono.Unix.Catalog.GetString("Error");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            // Internal child ocmgtk.NoDBDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.image30 = new Gtk.Image();
            this.image30.Name = "image30";
            this.image30.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-error", Gtk.IconSize.Dialog, 48);
            this.hbox1.Add(this.image30);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.image30]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Unable to open database");
            this.label1.UseMarkup = true;
            this.hbox1.Add(this.label1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            w1.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(w1[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Internal child ocmgtk.NoDBDialog.ActionArea
            Gtk.HButtonBox w5 = this.ActionArea;
            w5.Name = "dialog1_ActionArea";
            w5.Spacing = 10;
            w5.BorderWidth = ((uint)(5));
            w5.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button268 = new Gtk.Button();
            this.button268.CanFocus = true;
            this.button268.Name = "button268";
            this.button268.UseUnderline = true;
            this.button268.Label = Mono.Unix.Catalog.GetString("New Database...");
            this.AddActionWidget(this.button268, 0);
            Gtk.ButtonBox.ButtonBoxChild w6 = ((Gtk.ButtonBox.ButtonBoxChild)(w5[this.button268]));
            w6.Expand = false;
            w6.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button267 = new Gtk.Button();
            this.button267.CanFocus = true;
            this.button267.Name = "button267";
            this.button267.UseUnderline = true;
            this.button267.Label = Mono.Unix.Catalog.GetString("Open Database...");
            this.AddActionWidget(this.button267, 0);
            Gtk.ButtonBox.ButtonBoxChild w7 = ((Gtk.ButtonBox.ButtonBoxChild)(w5[this.button267]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button269 = new Gtk.Button();
            this.button269.CanFocus = true;
            this.button269.Name = "button269";
            this.button269.UseUnderline = true;
            this.button269.Label = Mono.Unix.Catalog.GetString("Quit");
            this.AddActionWidget(this.button269, 0);
            Gtk.ButtonBox.ButtonBoxChild w8 = ((Gtk.ButtonBox.ButtonBoxChild)(w5[this.button269]));
            w8.Position = 2;
            w8.Expand = false;
            w8.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 417;
            this.DefaultHeight = 135;
            this.Show();
            this.button268.Clicked += new System.EventHandler(this.NewDBClicked);
            this.button267.Clicked += new System.EventHandler(this.OpenDBClicked);
            this.button269.Clicked += new System.EventHandler(this.QuitClicked);
        }
    }
}