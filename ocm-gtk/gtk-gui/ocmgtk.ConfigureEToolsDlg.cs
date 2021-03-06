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
    
    
    public partial class ConfigureEToolsDlg {
        
        private Gtk.HBox hbox1;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView commandView;
        
        private Gtk.VButtonBox vbuttonbox1;
        
        private Gtk.Button addButton;
        
        private Gtk.Button editButton;
        
        private Gtk.Button removeButton;
        
        private Gtk.Button buttonClose;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.ConfigureEToolsDlg
            this.Name = "ocmgtk.ConfigureEToolsDlg";
            this.Title = Mono.Unix.Catalog.GetString("External Tools...");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.BorderWidth = ((uint)(6));
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            // Internal child ocmgtk.ConfigureEToolsDlg.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.commandView = new Gtk.TreeView();
            this.commandView.CanFocus = true;
            this.commandView.Name = "commandView";
            this.GtkScrolledWindow.Add(this.commandView);
            this.hbox1.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.GtkScrolledWindow]));
            w3.Position = 0;
            // Container child hbox1.Gtk.Box+BoxChild
            this.vbuttonbox1 = new Gtk.VButtonBox();
            this.vbuttonbox1.Name = "vbuttonbox1";
            this.vbuttonbox1.Spacing = 6;
            this.vbuttonbox1.LayoutStyle = ((Gtk.ButtonBoxStyle)(3));
            // Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
            this.addButton = new Gtk.Button();
            this.addButton.CanFocus = true;
            this.addButton.Name = "addButton";
            this.addButton.UseUnderline = true;
            this.addButton.Label = Mono.Unix.Catalog.GetString("Add");
            this.vbuttonbox1.Add(this.addButton);
            Gtk.ButtonBox.ButtonBoxChild w4 = ((Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1[this.addButton]));
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
            this.editButton = new Gtk.Button();
            this.editButton.Sensitive = false;
            this.editButton.CanFocus = true;
            this.editButton.Name = "editButton";
            this.editButton.UseUnderline = true;
            this.editButton.Label = Mono.Unix.Catalog.GetString("Edit");
            this.vbuttonbox1.Add(this.editButton);
            Gtk.ButtonBox.ButtonBoxChild w5 = ((Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1[this.editButton]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
            this.removeButton = new Gtk.Button();
            this.removeButton.Sensitive = false;
            this.removeButton.CanFocus = true;
            this.removeButton.Name = "removeButton";
            this.removeButton.UseUnderline = true;
            this.removeButton.Label = Mono.Unix.Catalog.GetString("Delete");
            this.vbuttonbox1.Add(this.removeButton);
            Gtk.ButtonBox.ButtonBoxChild w6 = ((Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1[this.removeButton]));
            w6.Position = 2;
            w6.Expand = false;
            w6.Fill = false;
            this.hbox1.Add(this.vbuttonbox1);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbuttonbox1]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            w1.Add(this.hbox1);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(w1[this.hbox1]));
            w8.Position = 0;
            // Internal child ocmgtk.ConfigureEToolsDlg.ActionArea
            Gtk.HButtonBox w9 = this.ActionArea;
            w9.Name = "dialog1_ActionArea";
            w9.Spacing = 10;
            w9.BorderWidth = ((uint)(5));
            w9.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonClose = new Gtk.Button();
            this.buttonClose.CanDefault = true;
            this.buttonClose.CanFocus = true;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseStock = true;
            this.buttonClose.UseUnderline = true;
            this.buttonClose.Label = "gtk-close";
            this.AddActionWidget(this.buttonClose, -7);
            Gtk.ButtonBox.ButtonBoxChild w10 = ((Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonClose]));
            w10.Expand = false;
            w10.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 300;
            this.Show();
            this.addButton.Clicked += new System.EventHandler(this.OnAddTool);
            this.editButton.Clicked += new System.EventHandler(this.OnEditClicked);
            this.removeButton.Clicked += new System.EventHandler(this.OnDeleteClicked);
            this.buttonClose.Clicked += new System.EventHandler(this.OnCloseClick);
        }
    }
}
