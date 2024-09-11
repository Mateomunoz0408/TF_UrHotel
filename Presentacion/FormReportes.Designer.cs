
namespace Presentacion
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgHabitacionesDisponibles = new System.Windows.Forms.DataGridView();
            this.btnCalcularGananciasDelHotel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dateSalidadGananciasDelHotel = new System.Windows.Forms.DateTimePicker();
            this.dateEntradaGananciasDelHotel = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelGananciasDelHotel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateSalidaHabitaciones = new System.Windows.Forms.DateTimePicker();
            this.dateEntradaHabitaciones = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dgHabitacionesOcupadas = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarPagoTotal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNombreCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcularCantidadDeClientesHospedados = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateSalidaCantidadDeClientesHospedados = new System.Windows.Forms.DateTimePicker();
            this.dateEntradaCantidadDeClientesHospedados = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.labelCantidadDeClientesHospedados = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPagoTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas = new System.Windows.Forms.Button();
            this.btnMostrarAlUsuarioQueRealizoMasReservas = new System.Windows.Forms.Button();
            this.btnVerReservas = new System.Windows.Forms.Button();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.dgReservasDeUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgHabitacionesDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHabitacionesOcupadas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservasDeUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHabitacionesDisponibles
            // 
            this.dgHabitacionesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHabitacionesDisponibles.Location = new System.Drawing.Point(11, 138);
            this.dgHabitacionesDisponibles.Name = "dgHabitacionesDisponibles";
            this.dgHabitacionesDisponibles.Size = new System.Drawing.Size(446, 217);
            this.dgHabitacionesDisponibles.TabIndex = 1;
            // 
            // btnCalcularGananciasDelHotel
            // 
            this.btnCalcularGananciasDelHotel.Location = new System.Drawing.Point(71, 107);
            this.btnCalcularGananciasDelHotel.Name = "btnCalcularGananciasDelHotel";
            this.btnCalcularGananciasDelHotel.Size = new System.Drawing.Size(126, 23);
            this.btnCalcularGananciasDelHotel.TabIndex = 14;
            this.btnCalcularGananciasDelHotel.Text = "Calcular";
            this.btnCalcularGananciasDelHotel.UseVisualStyleBackColor = true;
            this.btnCalcularGananciasDelHotel.Click += new System.EventHandler(this.btnCalcularGananciasDelHotel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "A:";
            // 
            // dateSalidadGananciasDelHotel
            // 
            this.dateSalidadGananciasDelHotel.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSalidadGananciasDelHotel.Location = new System.Drawing.Point(46, 72);
            this.dateSalidadGananciasDelHotel.Name = "dateSalidadGananciasDelHotel";
            this.dateSalidadGananciasDelHotel.Size = new System.Drawing.Size(200, 20);
            this.dateSalidadGananciasDelHotel.TabIndex = 12;
            // 
            // dateEntradaGananciasDelHotel
            // 
            this.dateEntradaGananciasDelHotel.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEntradaGananciasDelHotel.Location = new System.Drawing.Point(46, 44);
            this.dateEntradaGananciasDelHotel.Name = "dateEntradaGananciasDelHotel";
            this.dateEntradaGananciasDelHotel.Size = new System.Drawing.Size(200, 20);
            this.dateEntradaGananciasDelHotel.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "De:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ganancias =";
            // 
            // labelGananciasDelHotel
            // 
            this.labelGananciasDelHotel.AutoSize = true;
            this.labelGananciasDelHotel.BackColor = System.Drawing.Color.White;
            this.labelGananciasDelHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGananciasDelHotel.Location = new System.Drawing.Point(122, 144);
            this.labelGananciasDelHotel.Name = "labelGananciasDelHotel";
            this.labelGananciasDelHotel.Size = new System.Drawing.Size(19, 20);
            this.labelGananciasDelHotel.TabIndex = 5;
            this.labelGananciasDelHotel.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(235, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Reporte de Ganancias del Hotel:";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(155, 80);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(126, 23);
            this.btnVer.TabIndex = 19;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "A:";
            // 
            // dateSalidaHabitaciones
            // 
            this.dateSalidaHabitaciones.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSalidaHabitaciones.Location = new System.Drawing.Point(257, 49);
            this.dateSalidaHabitaciones.Name = "dateSalidaHabitaciones";
            this.dateSalidaHabitaciones.Size = new System.Drawing.Size(200, 20);
            this.dateSalidaHabitaciones.TabIndex = 17;
            // 
            // dateEntradaHabitaciones
            // 
            this.dateEntradaHabitaciones.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEntradaHabitaciones.Location = new System.Drawing.Point(31, 49);
            this.dateEntradaHabitaciones.Name = "dateEntradaHabitaciones";
            this.dateEntradaHabitaciones.Size = new System.Drawing.Size(200, 20);
            this.dateEntradaHabitaciones.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "De:";
            // 
            // dgHabitacionesOcupadas
            // 
            this.dgHabitacionesOcupadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHabitacionesOcupadas.Location = new System.Drawing.Point(11, 386);
            this.dgHabitacionesOcupadas.Name = "dgHabitacionesOcupadas";
            this.dgHabitacionesOcupadas.Size = new System.Drawing.Size(446, 217);
            this.dgHabitacionesOcupadas.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Habitaciones Ocupadas:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Habitaciones Disponibles:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.btnCalcularGananciasDelHotel);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.dateSalidadGananciasDelHotel);
            this.groupBox4.Controls.Add(this.dateEntradaGananciasDelHotel);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.labelGananciasDelHotel);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(21, 451);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 169);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.btnVer);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dateSalidaHabitaciones);
            this.groupBox3.Controls.Add(this.dateEntradaHabitaciones);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dgHabitacionesOcupadas);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dgHabitacionesDisponibles);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(375, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 609);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(311, 16);
            this.label17.TabIndex = 20;
            this.label17.Text = "Reporte de disponibilidad de Habitaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Reportes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pago Total =";
            // 
            // btnBuscarPagoTotal
            // 
            this.btnBuscarPagoTotal.Location = new System.Drawing.Point(95, 85);
            this.btnBuscarPagoTotal.Name = "btnBuscarPagoTotal";
            this.btnBuscarPagoTotal.Size = new System.Drawing.Size(135, 23);
            this.btnBuscarPagoTotal.TabIndex = 3;
            this.btnBuscarPagoTotal.Text = "Buscar";
            this.btnBuscarPagoTotal.UseVisualStyleBackColor = true;
            this.btnBuscarPagoTotal.Click += new System.EventHandler(this.btnBuscarPagoTotal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Cliente:";
            // 
            // cmbNombreCliente
            // 
            this.cmbNombreCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombreCliente.FormattingEnabled = true;
            this.cmbNombreCliente.Location = new System.Drawing.Point(125, 48);
            this.cmbNombreCliente.Name = "cmbNombreCliente";
            this.cmbNombreCliente.Size = new System.Drawing.Size(199, 24);
            this.cmbNombreCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reporte de Pago Total de un Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.btnCalcularCantidadDeClientesHospedados);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateSalidaCantidadDeClientesHospedados);
            this.groupBox2.Controls.Add(this.dateEntradaCantidadDeClientesHospedados);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.labelCantidadDeClientesHospedados);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(21, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 169);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // btnCalcularCantidadDeClientesHospedados
            // 
            this.btnCalcularCantidadDeClientesHospedados.Location = new System.Drawing.Point(79, 107);
            this.btnCalcularCantidadDeClientesHospedados.Name = "btnCalcularCantidadDeClientesHospedados";
            this.btnCalcularCantidadDeClientesHospedados.Size = new System.Drawing.Size(126, 23);
            this.btnCalcularCantidadDeClientesHospedados.TabIndex = 19;
            this.btnCalcularCantidadDeClientesHospedados.Text = "Calcular";
            this.btnCalcularCantidadDeClientesHospedados.UseVisualStyleBackColor = true;
            this.btnCalcularCantidadDeClientesHospedados.Click += new System.EventHandler(this.btnCalcularCantidadDeClientesHospedados_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "A:";
            // 
            // dateSalidaCantidadDeClientesHospedados
            // 
            this.dateSalidaCantidadDeClientesHospedados.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSalidaCantidadDeClientesHospedados.Location = new System.Drawing.Point(54, 72);
            this.dateSalidaCantidadDeClientesHospedados.Name = "dateSalidaCantidadDeClientesHospedados";
            this.dateSalidaCantidadDeClientesHospedados.Size = new System.Drawing.Size(200, 20);
            this.dateSalidaCantidadDeClientesHospedados.TabIndex = 17;
            // 
            // dateEntradaCantidadDeClientesHospedados
            // 
            this.dateEntradaCantidadDeClientesHospedados.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEntradaCantidadDeClientesHospedados.Location = new System.Drawing.Point(54, 44);
            this.dateEntradaCantidadDeClientesHospedados.Name = "dateEntradaCantidadDeClientesHospedados";
            this.dateEntradaCantidadDeClientesHospedados.Size = new System.Drawing.Size(200, 20);
            this.dateEntradaCantidadDeClientesHospedados.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "De:";
            // 
            // labelCantidadDeClientesHospedados
            // 
            this.labelCantidadDeClientesHospedados.AutoSize = true;
            this.labelCantidadDeClientesHospedados.BackColor = System.Drawing.Color.White;
            this.labelCantidadDeClientesHospedados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadDeClientesHospedados.Location = new System.Drawing.Point(204, 141);
            this.labelCantidadDeClientesHospedados.Name = "labelCantidadDeClientesHospedados";
            this.labelCantidadDeClientesHospedados.Size = new System.Drawing.Size(19, 20);
            this.labelCantidadDeClientesHospedados.TabIndex = 5;
            this.labelCantidadDeClientesHospedados.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total de Clientes Hospedados:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Reporte de Cantidad de Clientes \r\nHospedados:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.labelPagoTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBuscarPagoTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbNombreCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 169);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // labelPagoTotal
            // 
            this.labelPagoTotal.AutoSize = true;
            this.labelPagoTotal.BackColor = System.Drawing.Color.White;
            this.labelPagoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagoTotal.Location = new System.Drawing.Point(130, 139);
            this.labelPagoTotal.Name = "labelPagoTotal";
            this.labelPagoTotal.Size = new System.Drawing.Size(19, 20);
            this.labelPagoTotal.TabIndex = 5;
            this.labelPagoTotal.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Fondo5;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 657);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Silver;
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas);
            this.groupBox5.Controls.Add(this.btnMostrarAlUsuarioQueRealizoMasReservas);
            this.groupBox5.Controls.Add(this.btnVerReservas);
            this.groupBox5.Controls.Add(this.cmbUsuarios);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.dgUsuarios);
            this.groupBox5.Controls.Add(this.dgReservasDeUsuarios);
            this.groupBox5.Location = new System.Drawing.Point(877, 36);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(472, 609);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(293, 16);
            this.label19.TabIndex = 21;
            this.label19.Text = "Reporte del desempeño de los Usuarios:";
            // 
            // btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas
            // 
            this.btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas.Location = new System.Drawing.Point(237, 350);
            this.btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas.Name = "btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas";
            this.btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas.Size = new System.Drawing.Size(220, 43);
            this.btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas.TabIndex = 19;
            this.btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas.Text = "Mostrar al Usuario con mayor recaudación en sus reservas";
            this.btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas.UseVisualStyleBackColor = true;
            this.btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas.Click += new System.EventHandler(this.btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas_Click);
            // 
            // btnMostrarAlUsuarioQueRealizoMasReservas
            // 
            this.btnMostrarAlUsuarioQueRealizoMasReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAlUsuarioQueRealizoMasReservas.Location = new System.Drawing.Point(11, 350);
            this.btnMostrarAlUsuarioQueRealizoMasReservas.Name = "btnMostrarAlUsuarioQueRealizoMasReservas";
            this.btnMostrarAlUsuarioQueRealizoMasReservas.Size = new System.Drawing.Size(220, 43);
            this.btnMostrarAlUsuarioQueRealizoMasReservas.TabIndex = 18;
            this.btnMostrarAlUsuarioQueRealizoMasReservas.Text = "Mostrar al Usuario que realizó más reservas";
            this.btnMostrarAlUsuarioQueRealizoMasReservas.UseVisualStyleBackColor = true;
            this.btnMostrarAlUsuarioQueRealizoMasReservas.Click += new System.EventHandler(this.btnMostrarAlUsuarioQueRealizoMasReservas_Click);
            // 
            // btnVerReservas
            // 
            this.btnVerReservas.Location = new System.Drawing.Point(319, 64);
            this.btnVerReservas.Name = "btnVerReservas";
            this.btnVerReservas.Size = new System.Drawing.Size(138, 23);
            this.btnVerReservas.TabIndex = 17;
            this.btnVerReservas.Text = "Ver Reservas";
            this.btnVerReservas.UseVisualStyleBackColor = true;
            this.btnVerReservas.Click += new System.EventHandler(this.btnVerReservas_Click);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(72, 63);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(212, 24);
            this.cmbUsuarios.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 16);
            this.label18.TabIndex = 15;
            this.label18.Text = "Usuario:";
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(11, 400);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.Size = new System.Drawing.Size(446, 203);
            this.dgUsuarios.TabIndex = 3;
            // 
            // dgReservasDeUsuarios
            // 
            this.dgReservasDeUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservasDeUsuarios.Location = new System.Drawing.Point(11, 102);
            this.dgReservasDeUsuarios.Name = "dgReservasDeUsuarios";
            this.dgReservasDeUsuarios.Size = new System.Drawing.Size(446, 217);
            this.dgReservasDeUsuarios.TabIndex = 1;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 657);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgHabitacionesDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHabitacionesOcupadas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservasDeUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHabitacionesDisponibles;
        private System.Windows.Forms.Button btnCalcularGananciasDelHotel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateSalidadGananciasDelHotel;
        private System.Windows.Forms.DateTimePicker dateEntradaGananciasDelHotel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelGananciasDelHotel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateSalidaHabitaciones;
        private System.Windows.Forms.DateTimePicker dateEntradaHabitaciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgHabitacionesOcupadas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarPagoTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalcularCantidadDeClientesHospedados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateSalidaCantidadDeClientesHospedados;
        private System.Windows.Forms.DateTimePicker dateEntradaCantidadDeClientesHospedados;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelCantidadDeClientesHospedados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPagoTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.DataGridView dgReservasDeUsuarios;
        private System.Windows.Forms.Button btnVerReservas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas;
        private System.Windows.Forms.Button btnMostrarAlUsuarioQueRealizoMasReservas;
    }
}