using ActividadFORM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BDContext bd = new BDContext();
            comboCurso.DataSource = bd.Cursos.ToList();
            comboCurso.DisplayMember = "Nombre";
        }

        private void comboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            BDContext bd = new BDContext();
            Curso cursoSelec = (Curso)comboCurso.SelectedItem;
            List<Profesore> profesoredelcurso = bd.Profesores.Where(Curso => Curso.idprofesor == cursoSelec.idprofesor).ToList();
            gridProfe.DataSource = profesoredelcurso;


            List<Alumno> alumnodelcurso = bd.Alumnos.Where(Curso => Curso.idCurso == cursoSelec.idCurso).ToList();
            gridAlum.DataSource = alumnodelcurso;
            gridProfe.Columns[2].Visible = false;
            
           
        }
    }
}
