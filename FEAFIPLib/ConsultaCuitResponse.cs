using FEAFIPLib;
public class ConsultaCuitResponse
{

    private string[] CondicionesIVA = { "Monotributo", "Responsable Inscripto", "IVA Exento", "Consumidor Final" };

    private FEAFIPLib.ServiceA4.persona _response;

    private bool FindTax(int TaxId)
    {
        if (!(_response.impuesto == null))
        {
            for (int I = 0; (I
                        <= (_response.impuesto.Length - 1)); I++)
            {
                if (((_response.impuesto[I].idImpuesto == TaxId)
                            && (_response.impuesto[I].estado == "ACTIVO")))
                {
                    return true;

                }

            }

        }
        return false;

    }

    public ConsultaCuitResponse(FEAFIPLib.ServiceA4.persona responseObj)
    {
        _response = responseObj;
    }

    public long idPersona
    {
        get
        {
            return _response.idPersona;
        }
    }

    public string tipoPersona
    {
        get
        {
            return _response.tipoPersona;
        }
    }

    public string nombre
    {
        get
        {
            if ((tipoPersona == "FISICA"))
            {
                return (_response.apellido + (" " + _response.nombre));
            }
            else
            {
                return _response.razonSocial;
            }

        }
    }

    public string tipoDocumento
    {
        get
        {
            try
            {
                return _response.tipoDocumento;
            }
            catch (System.Exception E)
            {
                return "";
            }

        }
    }

    public string numeroDocumento
    {
        get
        {
            try
            {
                return _response.numeroDocumento;
            }
            catch (System.Exception E)
            {
                return "";
            }

        }
    }

    public string domicilioFiscal_direccion
    {
        get
        {
            try
            {
                return _response.domicilio[0].direccion;
            }
            catch (System.Exception E)
            {
                return "";
            }

        }
    }

    public string domicilioFiscal_localidad
    {
        get
        {
            try
            {
                return _response.domicilio[0].localidad;
            }
            catch (System.Exception E)
            {
                return "";
            }

        }
    }

    public string domicilioFiscal_codPostal
    {
        get
        {
            try
            {
                return _response.domicilio[0].codPostal;
            }
            catch (System.Exception e)
            {
                return "";
            }

        }
    }

    public int domicilioFiscal_idProvincia
    {
        get
        {
            try
            {
                return _response.domicilio[0].idProvincia;
            }
            catch (System.Exception E)
            {
                return 0;
            }

        }
    }

    public int condicionIVA
    {
        get
        {
            if (this.FindTax(20))
            {
                return 0;
                //  Monotributo
            }
            else if (this.FindTax(30))
            {
                return 1;
                //  Responsable inscripto
            }
            else if (this.FindTax(32))
            {
                return 2;
                //  IVA Exento
            }
            else
            {
                return 3;
                //  Consumidor final
            }

        }
    }

    public string condicionIVADesc
    {
        get
        {
            return CondicionesIVA[this.condicionIVA];
        }
    }
}