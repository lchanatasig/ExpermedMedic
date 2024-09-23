namespace MedicExpermed.Models
{
    public class ConsultDetails
    {

        public int ConsultaId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string HistorialConsulta { get; set; }
        public int SecuencialConsulta { get; set; }
        public int PacienteConsulta { get; set; }
        public string PrimerNombrePaciente { get; set; }
        public string SegundoNombrePaciente { get; set; }
        public string PrimerApellidoPaciente { get; set; }
        public string SegundoApellidoPaciente { get; set; }
        public int CiPacientes { get; set; }
        public int EdadPacientes { get; set; }
        public string DireccionPacientes { get; set; }
        public string GeneroPaciente { get; set; }
        public string MotivoConsulta { get; set; }
        public string EnfermedadConsulta { get; set; }
        public string NombreParienteConsulta { get; set; }
        public string SignosAlarma { get; set; }
        public string ReconoFarmacologicas { get; set; }
        public int TipoParienteConsulta { get; set; }
        public string TelefonoPariente { get; set; }
        public string TemperaturaConsulta { get; set; }
        public string FrecuenciaRespiratoria { get; set; }
        public string PresionSistolica { get; set; }
        public string PresionDiastolica { get; set; }
        public string PulsoConsulta { get; set; }
        public string PesoConsulta { get; set; }
        public string TallaConsulta { get; set; }
        public string PlanTratamiento { get; set; }
        public string ObservacionConsulta { get; set; }
        public string AntecedentesPersonales { get; set; }
        public int DiasIncapacidad { get; set; }
        public int MedicoConsultaD { get; set; }
        public string NombresMedico { get; set; }
        public string ApellidosMedico { get; set; }
        public string DireccionMedico { get; set; }
        public string EmailMedico { get; set; }
        public string TelefonoMedico { get; set; }
        public string CodigoMedico { get; set; }
        public int EspecialidadId { get; set; }
        public string NombreEspecialidad { get; set; }



        // ... Other main consult fields

        public AntecedentesFamiliares AntecedentesFamiliares { get; set; } = new AntecedentesFamiliares();
        public OrganosSistemas OrganosSistemas { get; set; } = new OrganosSistemas();
        public ExamenFisicos ExamenFisico { get; set; } = new ExamenFisicos();
        public List<Diagnosticos> Diagnosticos { get; set; } = new List<Diagnosticos> { };
        public List<Medicamentos> Medicamentos { get; set; } = new List<Medicamentos> { };
        public List<Alergia> Alergias { get; set; } = new List<Alergia> { };
        public List<Cirugia> Cirugias { get; set; } = new List<Cirugia> { }; 
        public List<Laboratorios> Laboratorios { get; set; } = new List<Laboratorios> { }; 
        public List<Imagenes> Imagenes { get; set; } = new List<Imagenes> { }; 
    }


    public class Diagnosticos
    {
        public int DiagnosticoId { get; set; }
        public string ObservacionDiagnostico { get; set; }
        public string NombreDiagnostico { get; set; }
        public string CIE10DIA { get; set; }
        public bool PresuntivoDiagnosticos { get; set; }
        public bool DefinitivoDiagnosticos { get; set; }
        public int EstadoDiagnostico { get; set; }
    }
    public class Medicamentos
    {
        public int MedicamentoId { get; set; }
        public string NombreMedicamento { get; set; }
        public string CIE10MED { get; set; }
        public string DosisMedicamento { get; set; }
        public int SecuencialMedicamento { get; set; }
        public string ObserMedicamento { get; set; }

    }
    public class Laboratorios
    {
        public int CatalogoLaboratorioId { get; set; }
        public string NombreLaboratorio { get; set; }
        public string CIE10LAB { get; set; }
        public string ObserLaboratorio { get; set; }
        public int CantidadLaboratorio { get; set; }
        public int EstadoLaboratorio { get; set; }
        

    }
    public class Imagenes
    {
        public int ImagenId { get; set; }
        public string NombreImagen { get; set; }
        public string ObserImagen { get; set; }
        public string CIE10IMG { get; set; }
        public int CantidadImagen { get; set; }

    }

    public class Alergia
    {
        public int AlergiaId { get; set; }
        public string NombreAlergia { get; set; }
        public string ObserAlergia { get; set; }


    }

    public class Cirugia
    {
        public int CirugiaId { get; set; }
        public string NombreCirugia { get; set; }
        public string ObserCirugia { get; set; }


    }


    public class AntecedentesFamiliares
    {
        public bool Cardiopatia { get; set; }
        public string ObserCardiopatia { get; set; }
        public string ParentescoCardiopatia { get; set; }
        public bool Diabetes { get; set; }
        public string ObserDiabetes { get; set; }
        public string ParentescoDiabetes { get; set; }
        // ... Otror antecedentes familiares 
        public bool EnfCardiovascular { get; set; }
        public string ObseEnfCardiovascular { get; set; }
        public string ParentescoEnCardiovascular { get; set; }

        public bool Hipertension { get; set; }
        public string ObserHipertension { get; set; }
        public string ParentescoHipertension { get; set; }

        public bool Cancer { get; set; }
        public string ObseCancer { get; set; }
        public string ParentescoCancer { get; set; }
        public bool Tuberculosis { get; set; }
        public string ObserTuberculosis { get; set; }
        public string ParentescoTuberculosis { get; set; }
        public bool EnfMental { get; set; }
        public string ObseEnfMenta { get; set; }

        public string ParentescoEnfMental { get; set; }
        public bool EnfInfecciosa { get; set; }
        public string ObsEnfInfecciosa { get; set; }
        public string ParentescoEnfInfecciosa { get; set; }
        public bool MalFormacion { get; set; }
        public string ObserMalFormacion { get; set; }
        public string ParentescoMalFormacion { get; set; }
        public bool Otro { get; set; }
        public string ObseOtro { get; set; }
        public string ParentescoOtro { get; set; }






        // ... Other antecedentes familiares fields
    }

    public class OrganosSistemas
    {
        public bool OrgSentidos { get; set; }
        public string ObserOrgSentidos { get; set; }
        public bool Respiratorio { get; set; }
        public string ObserRespiratorio { get; set; }
        public bool CardioVascular { get; set; }
        public string ObserCardiovascular { get; set; }
        public bool Digestivo { get; set; }
        public string ObserDigestivo { get; set; }
        public bool Genital { get; set; }
        public string ObserGenital { get; set; }
        public bool Urinario { get; set; }
        public string ObserUrinario { get; set; }
        public bool MEsqueletico { get; set; }
        public string ObserMEsqueletico { get; set; }
        public bool Endocrino { get; set; }
        public string ObserEndocrino { get; set; }
        public bool Linfatico { get; set; }
        public string ObserLinfatico { get; set; }
        public bool Nervioso { get; set; }
        public string ObserNervioso { get; set; }



        // ... Other organos y sistemas fields
    }

    public class ExamenFisicos
    {
        public bool Cabeza { get; set; }
        public string ObserCabeza { get; set; }
        public bool Cuello { get; set; }
        public string ObserCuello { get; set; }

        public bool Torax { get; set; }
        public string ObserTorax { get; set; }

        public bool Abdomen { get; set; }

        public string ObserAbdomen { get; set; }

        public bool Pelvis { get; set; }
        public string ObserPelvis { get; set; }

        public bool Extremidades { get; set; }
        public string ObserExtremidades { get; set; }




        // ... Other examen físico fields
    }


}
