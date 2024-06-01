using Gestion_Bodega.Bodega;
using Gestion_Bodega.Clases.Bodega;
using Gestion_Bodega.Clases.Contenedor;
using Gestion_Bodega.Clases.Material;
using Gestion_Bodega.Clases.Movimientos;
using Gestion_Bodega.Clases.Tipo_Contenedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using System.IO;
using Gestion_Bodega.Clases_Respuesta;
using Gestion_Bodega.Forms.Materiales;
using Gestion_Bodega.Forms.Movimientos;

namespace Gestion_Bodega.Clases
{
    public class CInterfaz
    {
        public string get_url_rest()
        {
            return "http://localhost:63920/api/"; //CAMBIAR
        }

        #region TIPO MATERIAL LISTAR
        // para poblar con Consulta el CMB
        public List<CTipoDeMaterial> tipo_material_listar(ref CError o_error)
        {
            o_error = new CError();
            //string x_entrada;

            string url = get_url_rest() + "values/tipo_material/listar";
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            WebResponse ws = request.GetResponse();
            CRespuesta_CTipoDeMaterial x_datos = new CRespuesta_CTipoDeMaterial(); //
            CRespuesta_CTipoDeMaterial x_respuesta = new CRespuesta_CTipoDeMaterial();
            try
            {
                Stream mistream = ws.GetResponseStream();
                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();
                x_datos = JsonConvert.DeserializeObject<CRespuesta_CTipoDeMaterial>(responseString);
                o_error = x_datos.o_error;
            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return null;
            }
            return x_datos.datos;
        }
        // fin poblar CMB tipo material
        #endregion

        #region MATERIALES
        public List<CMaterial> listarMateriales(CMaterial material, ref CError o_error)
        {

            o_error = new CError();

            string url = get_url_rest() + "values/material/listar?id=" + material.id + "&nombre=" + material.nombre + "&codigo=" + material.codigo + "&empresa=" + material.empresa;
            WebRequest request = WebRequest.Create(url);

            request.Method = "GET";

            WebResponse ws = request.GetResponse();

            CRespuestaListaMaterial x_datos = new CRespuestaListaMaterial();
            CRespuestaListaMaterial x_respuesta = new CRespuestaListaMaterial();

            try
            {
                Stream mistream = ws.GetResponseStream();

                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();
                x_datos = JsonConvert.DeserializeObject<CRespuestaListaMaterial>(responseString);

                o_error = x_datos.o_error;
            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return null;
            }

            return x_datos.datos;

        }
        ///FIN LISTA MATERIALES\\\
        //

        /// 
        /// INGRESAR \\\

        public int IngresarMateriales(CMaterial material, CTipoDeMaterial tipo_material, ref CError o_error)
        {
            o_error = new CError();
            wfrm_ListarMateriales x_listar_materiales = new wfrm_ListarMateriales();
            //ListarMateriales listar_materiales_grilla = new ListarMateriales(ref o_error);
            //IngresarMaterial x_ingresar = new IngresarMaterial(ref o_error);

            string x_data = //"{\"id\":" + material.id.ToString() +
                "{" +
                /*"," +*/ "\"codigo\":\"" + material.codigo + "\"" +
                "," + "\"nombre\":\"" + material.nombre + "\"" +
                "," + "\"descripcion\":\"" + material.descripcion + "\"" +
                "," + "\"estado\":\"" + material.estado + "\"" +
                "," + "\"empresa\":\"" + material.empresa + "\"" +
                "," + "\"unidades\":\"" + material.unidades + "\"" +
                "," + "\"peso\":" + material.peso.ToString() +
                "," + "\"ancho\":" + material.ancho.ToString() +
                "," + "\"alto\":" + material.alto.ToString() +
                "," + "\"largo\":" + material.largo.ToString() +
                "," + "\"seriado\":\"" + material.seriado + "\"" +
                "," + "\"tipo_material\":" + tipo_material.id.ToString() +
                "}";

            byte[] dataStream = Encoding.UTF8.GetBytes(x_data);

            string url = get_url_rest() + "values/material/ingresar";

            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = dataStream.Length;
            Stream newStream = request.GetRequestStream();
            newStream.Write(dataStream, 0, dataStream.Length);

            WebResponse ws = request.GetResponse();
            CRespuestaInt x_datos = new CRespuestaInt();

            try
            {

                Stream mistream = ws.GetResponseStream();
                var x_material = JsonConvert.SerializeObject(material);  //Informacion de el material ingresado a serializar
                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();
                //x_datos = JsonConvert.DeserializeObject(responseString, typeof(CRespuestaInt));

                //x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);
                x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);

                int respuesta_id_valor;
                string respuesta_error;

                if (x_datos.o_error.id != 0)
                {
                    respuesta_id_valor = x_datos.valor;
                    respuesta_error = x_datos.o_error.mensaje;
                }
                else
                {

                }

                //StringContent contentenido = new StringContent(x_material);

                o_error = x_datos.o_error;

            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return -1;
            }
            x_listar_materiales.cargar_grilla();
            return x_datos.valor;
        }
        // FIN INGRESAR \\



        // MODIFICAR \\
        public int ModificarMateriales(CMaterial material, ref CError o_error)
        {
            o_error = new CError();

            wfrm_ModificarMaterial x_modificar = new wfrm_ModificarMaterial();

            string x_data = "{\"id\":" + material.id.ToString() +
               "," + "\"codigo\":\"" + material.codigo + "\"" +
               "," + "\"nombre\":\"" + material.nombre + "\"" +
               "," + "\"descripcion\":\"" + material.descripcion + "\"" +
               "," + "\"estado\":\"" + material.estado + "\"" +
               "," + "\"empresa\":\"" + material.empresa + "\"" +
               "," + "\"unidades\":\"" + material.unidades + "\"" +
               "," + "\"peso\":" + material.peso.ToString() +
               "," + "\"ancho\":" + material.ancho.ToString() +
               "," + "\"alto\":" + material.alto.ToString() +
               "," + "\"largo\":" + material.largo.ToString() +
               "," + "\"seriado\":\"" + material.seriado + "\"" +
               "," + "\"tipo_material\":" + material.tipo_material.ToString() +
               "}";


            byte[] dataStream = Encoding.UTF8.GetBytes(x_data);

            string url = get_url_rest() + "values/material/modificar";

            WebRequest request = WebRequest.Create(url);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = dataStream.Length;

            Stream newStream = request.GetRequestStream();
            newStream.Write(dataStream, 0, dataStream.Length);

            WebResponse ws = request.GetResponse();

            CRespuestaInt x_datos = new CRespuestaInt();

            try
            {

                Stream mistream = ws.GetResponseStream();

                var x_material = JsonConvert.SerializeObject(material);  //Informacion de el material ingresado a serializar

                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();

                x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);

                int respuesta_id_valor;
                string respuesta_error;

                if (x_datos.valor != 0 || x_datos.o_error.mensaje != "")
                {
                    respuesta_id_valor = x_datos.valor;
                    respuesta_error = x_datos.o_error.mensaje;
                }
                else
                {

                }

                StringContent contentenido = new StringContent(x_material);

                o_error = x_datos.o_error;

            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return -1;
            }


            return x_datos.valor;
        }

        public int EliminarMaterial(CMaterial material, ref CError o_error)
        {
            o_error = new CError();
            string url = get_url_rest() + "values/material/eliminar/" + material.id;
            WebRequest request = WebRequest.Create(url);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            Stream newStream = request.GetRequestStream();
            WebResponse ws = request.GetResponse();
            CRespuestaInt x_datos = new CRespuestaInt();

            try
            {

                Stream mistream = ws.GetResponseStream();

                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();

                x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);


                o_error = x_datos.o_error;

            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return -1;
            }

            return x_datos.valor;
        }

        // FIN ELIMINAR \\
        #endregion


        #region BODEGAS
        public List<CBodega> listar_bodegas(CBodega bodega, ref CError o_error)
        {

            o_error = new CError();

            string url = get_url_rest() + "values/bodegas/listar_filtro?id=" + bodega.id + "&abreviatura=" + bodega.abreviatura + "&estado=" + bodega.estado;
            WebRequest request = WebRequest.Create(url);

            request.Method = "GET";

            WebResponse ws = request.GetResponse();
            CRespuestaBodegaLista x_datos = new CRespuestaBodegaLista();
            CRespuestaBodegaLista x_respuesta = new CRespuestaBodegaLista();

            try
            {
                Stream mistream = ws.GetResponseStream();

                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();
                x_datos = JsonConvert.DeserializeObject<CRespuestaBodegaLista>(responseString);

                o_error = x_datos.o_error;
            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return null;
            }

            return x_datos.datos;

        }

        //
        public int bodega_ingresar(CBodega bodega, ref CError o_error)
        {
            o_error = new CError();

            wfrm_Listar_bodegas x_listar_bodegas = new wfrm_Listar_bodegas();

            wfrm_ingresar_bodega x_modificar = new wfrm_ingresar_bodega();

            string x_data = "{\"id\":\"" + bodega.id + "\"" +
               "," + "\"descripcion\":\"" + bodega.descripcion + "\"" +
                "," + "\"abreviatura\":\"" + bodega.abreviatura + "\"" +
                "," + "\"estado\":\"" + bodega.estado + "\"" +
                "}";

            byte[] dataStream = Encoding.UTF8.GetBytes(x_data);

            string url = get_url_rest() + "values/Bodegas/ingresar";

            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = dataStream.Length;
            Stream newStream = request.GetRequestStream();
            newStream.Write(dataStream, 0, dataStream.Length);
            WebResponse ws = request.GetResponse();
            CRespuestaInt x_datos = new CRespuestaInt();

            try
            {

                Stream mistream = ws.GetResponseStream();
                var x_bodega = JsonConvert.SerializeObject(bodega);  //Informacion de el material ingresado a serializar
                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();

                x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);

                int respuesta_id_valor;
                string respuesta_error;

                if (x_datos.o_error.id != 0)
                {
                    respuesta_id_valor = x_datos.valor;
                    respuesta_error = x_datos.o_error.mensaje;
                }
                else
                {

                }

                o_error = x_datos.o_error;

            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return -1;
            }
            x_listar_bodegas.cargar_grilla();
            return x_datos.valor;
        }


        //

        public int ModificarBodegas(CBodega bodega, ref CError o_error)
        {
            o_error = new CError();

            string x_data = "{\"id\":\"" + bodega.id + "\"" +
               "," + "\"descripcion\":\"" + bodega.descripcion + "\"" +
               "," + "\"abreviatura\":\"" + bodega.abreviatura + "\"" +
               "," + "\"estado\":\"" + bodega.estado + "\"" +
               "}";

            byte[] dataStream = Encoding.UTF8.GetBytes(x_data);

            string url = get_url_rest() + "values/bodegas/modificar";

            WebRequest request = WebRequest.Create(url);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = dataStream.Length;

            Stream newStream = request.GetRequestStream();
            newStream.Write(dataStream, 0, dataStream.Length);

            WebResponse ws = request.GetResponse();

            CRespuestaInt x_datos = new CRespuestaInt();

            try
            {

                Stream mistream = ws.GetResponseStream();

                var x_bodega = JsonConvert.SerializeObject(bodega);  //Informacion de el material ingresado a serializar

                //var x_bodega = JsonConvert.SerializeObject(x_modificar, Formatting.Indented, new JsonSerializerSettings
                //{
                //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore //OPCION 4, LINEA MODIFICADA, SE UTILIZABA "SERIALIZE" DESPUES DEL PUNTO FINAL

                //    //PreserveReferencesHandling = PreserveReferencesHandling.Objects //OPCION2
                //});


                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();

                x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);

                int respuesta_id_valor;
                string respuesta_error;

                if (x_datos.valor != 0 || x_datos.o_error.mensaje != "")
                {
                    respuesta_id_valor = x_datos.valor;
                    respuesta_error = x_datos.o_error.mensaje;
                }
                else
                {

                }

                StringContent contentenido = new StringContent(x_bodega);

                o_error = x_datos.o_error;

            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return -1;
            }


            return x_datos.valor;
        }

        //



        public int EliminarBodega(CBodega bodega, ref CError o_error)
        {
            o_error = new CError();
            string url = get_url_rest() + "values/bodegas/eliminar/" + bodega.id;
            WebRequest request = WebRequest.Create(url);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            Stream newStream = request.GetRequestStream();
            WebResponse ws = request.GetResponse();
            CRespuestaInt x_datos = new CRespuestaInt();

            try
            {

                Stream mistream = ws.GetResponseStream();

                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();

                x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);


                o_error = x_datos.o_error;

            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return -1;
            }

            return x_datos.valor;
        }





        ///


        #endregion

        #region CONTENEDOR
        public List<CContenedor> listar_Materiales_bodegas(CContenedor material, ref CError o_error)
        {

            o_error = new CError();
            string url = get_url_rest() + "values/CContenedor_get_materiales/listar_material_bodega?id=" + material.id + "&nombre=" + material.nombre + "&id_contenedor=" + material.id_contenedor;

            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            WebResponse ws = request.GetResponse();
            CRespuestaCContenedor x_datos = new CRespuestaCContenedor();
            CRespuestaCContenedor x_respuesta = new CRespuestaCContenedor();

            try
            {
                Stream mistream = ws.GetResponseStream();
                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();
                x_datos = JsonConvert.DeserializeObject<CRespuestaCContenedor>(responseString);
                o_error = x_datos.o_error;
            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return null;
            }
            return x_datos.datos;
        }

        #endregion


        #region MOVIMIENTOS
        public List<CMovimientos> listar_movimientos(CMovimientos movimiento, ref CError o_error)
        {

            o_error = new CError();
            string url = get_url_rest() + "values/Movimientos/listado?id=" + movimiento.id + "&id_material=" + movimiento.id_material + "&tipo_operacion=" + movimiento.tipo_operacion + "&usuario=" + movimiento.usuario;
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            WebResponse ws = request.GetResponse();
            CRespuesta_Movimientos_Lista x_datos = new CRespuesta_Movimientos_Lista();
            CRespuesta_Movimientos_Lista x_respuesta = new CRespuesta_Movimientos_Lista();

            try
            {

                Stream mistream = ws.GetResponseStream();
                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();
                x_datos = JsonConvert.DeserializeObject<CRespuesta_Movimientos_Lista>(responseString);
                o_error = x_datos.o_error;

            }

            catch (Exception e)
            {

                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return null;

            }

            return x_datos.datos;

        }


        // MODIFICAR \\
        public int Movimientos_modificar(CMovimientos movimiento, ref CError o_error)
        {
            o_error = new CError();

            wfrm_movimientos_modificar x_movimiento_modificar = new wfrm_movimientos_modificar();

            string x_data = "{\"id\":" + movimiento.id.ToString() +
               "," + "\"id_contenedor\":" + movimiento.id_contenedor.ToString() +
               "," + "\"id_material\":" + movimiento.id_material.ToString() +
               "," + "\"tipo_operacion\":\"" + movimiento.tipo_operacion + "\"" +
               "," + "\"cantidad\":" + movimiento.cantidad.ToString() +
               "," + "\"usuario\":\"" + movimiento.usuario + "\"" +
               "," + "\"id_documento_origen\":" + movimiento.ID_DOCUMENTO_ORIGEN.ToString() +
               "," + "\"id_tipo_documento_origen\":" + movimiento.ID_TIPO_DOCUMENTO_ORIGEN.ToString() +
               "}";

            byte[] dataStream = Encoding.UTF8.GetBytes(x_data);

            string url = get_url_rest() + "values/movimientos/modificar";

            WebRequest request = WebRequest.Create(url);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = dataStream.Length;

            Stream newStream = request.GetRequestStream();
            newStream.Write(dataStream, 0, dataStream.Length);

            WebResponse ws = request.GetResponse();

            CRespuestaInt x_datos = new CRespuestaInt();

            try
            {

                Stream mistream = ws.GetResponseStream();

                //var x_movimiento = JsonConvert.SerializeObject(x_movimiento_modificar);  //Informacion de el material ingresado a serializar

                ////
                var x_movimiento = JsonConvert.SerializeObject(x_movimiento_modificar, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore //OPCION 4

                    //PreserveReferencesHandling = PreserveReferencesHandling.Objects
                });
                ////


                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();

                x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);

                int respuesta_id_valor;
                string respuesta_error;

                if (x_datos.valor != 0 || x_datos.o_error.mensaje != "")
                {
                    respuesta_id_valor = x_datos.valor;
                    respuesta_error = x_datos.o_error.mensaje;
                }
                else
                {

                }

                StringContent contentenido = new StringContent(x_movimiento);

                o_error = x_datos.o_error;

            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return -1;
            }


            return x_datos.valor;
        }


        public int Movimiento_Eliminar(CMovimientos movimiento, ref CError o_error)
        {
            o_error = new CError();
            string url = get_url_rest() + "values/Movimientos/eliminar/" + movimiento.id;
            WebRequest request = WebRequest.Create(url);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            Stream newStream = request.GetRequestStream();
            WebResponse ws = request.GetResponse();
            CRespuestaInt x_datos = new CRespuestaInt();

            try
            {

                Stream mistream = ws.GetResponseStream();

                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();

                x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);


                o_error = x_datos.o_error;

            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return -1;
            }
            return x_datos.valor;
        }

        #endregion


        #region CTIPO_CONTENEDOR


        public List<CTipoContenedor> leer_datos(/*CTipoContenedor CTipo_contenedor,*/ ref CError o_error)
        {

            o_error = new CError();

            string url = get_url_rest() + "inv_tipo_contenedor/listar"; //?id=" + material.id + "&nombre=" + material.nombre + "&codigo=" + material.codigo + "&empresa=" + material.empresa;
            WebRequest request = WebRequest.Create(url);

            request.Method = "GET";

            WebResponse ws = request.GetResponse();

            CTipoContenedor_respuesta x_datos = new CTipoContenedor_respuesta();
            CTipoContenedor_respuesta x_respuesta = new CTipoContenedor_respuesta();

            try
            {
                Stream mistream = ws.GetResponseStream();

                StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
                string responseString = mireader.ReadToEnd();
                x_datos = JsonConvert.DeserializeObject<CTipoContenedor_respuesta>(responseString);

                o_error = x_datos.o_error;
            }
            catch (Exception e)
            {
                o_error = new CError();
                o_error.id = 100;
                o_error.mensaje = e.Message;
                return null;
            }

            return x_datos.datos;

        }




        //public List<CMaterial> listarMateriales(CMaterial material, ref CError o_error)
        //{

        //    o_error = new CError();

        //    string url = get_url_rest() + "values/material/listar?id=" + material.id + "&nombre=" + material.nombre + "&codigo=" + material.codigo + "&empresa=" + material.empresa;
        //    WebRequest request = WebRequest.Create(url);

        //    request.Method = "GET";

        //    WebResponse ws = request.GetResponse();

        //    CRespuestaListaMaterial x_datos = new CRespuestaListaMaterial();
        //    CRespuestaListaMaterial x_respuesta = new CRespuestaListaMaterial();

        //    try
        //    {
        //        Stream mistream = ws.GetResponseStream();

        //        StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
        //        string responseString = mireader.ReadToEnd();
        //        x_datos = JsonConvert.DeserializeObject<CRespuestaListaMaterial>(responseString);

        //        o_error = x_datos.o_error;
        //    }
        //    catch (Exception e)
        //    {
        //        o_error = new CError();
        //        o_error.id = 100;
        //        o_error.mensaje = e.Message;
        //        return null;
        //    }

        //    return x_datos.datos;

        //}
        /////FIN LISTA MATERIALES\\\
        ////

        ///// 
        ///// INGRESAR \\\

        //public int IngresarMateriales(CMaterial material, CTipoDeMaterial tipo_material, ref CError o_error)
        //{
        //    o_error = new CError();
        //    ListarMateriales x_listar_materiales = new ListarMateriales(ref o_error);
        //    ListarMateriales listar_materiales_grilla = new ListarMateriales(ref o_error);
        //    IngresarMaterial x_ingresar = new IngresarMaterial(ref o_error);

        //    string x_data = "{\"id\":" + material.id.ToString() +
        //        "," + "\"codigo\":\"" + material.codigo + "\"" +
        //        "," + "\"nombre\":\"" + material.nombre + "\"" +
        //        "," + "\"descripcion\":\"" + material.descripcion + "\"" +
        //        "," + "\"estado\":\"" + material.estado + "\"" +
        //        "," + "\"empresa\":\"" + material.empresa + "\"" +
        //        "," + "\"unidades\":\"" + material.unidades + "\"" +
        //        "," + "\"peso\":" + material.peso.ToString() +
        //        "," + "\"ancho\":" + material.ancho.ToString() +
        //        "," + "\"alto\":" + material.alto.ToString() +
        //        "," + "\"largo\":" + material.largo.ToString() +
        //        "," + "\"seriado\":\"" + material.seriado + "\"" +
        //        "," + "\"tipo_material\":" + tipo_material.id.ToString() +
        //        "}";

        //    byte[] dataStream = Encoding.UTF8.GetBytes(x_data);

        //    string url = get_url_rest() + "values/material/ingresar";

        //    WebRequest request = WebRequest.Create(url);
        //    request.Method = "POST";
        //    request.ContentType = "application/json";
        //    request.ContentLength = dataStream.Length;
        //    Stream newStream = request.GetRequestStream();
        //    newStream.Write(dataStream, 0, dataStream.Length);
        //    WebResponse ws = request.GetResponse();
        //    CRespuestaInt x_datos = new CRespuestaInt();

        //    try
        //    {

        //        Stream mistream = ws.GetResponseStream();
        //        var x_material = JsonConvert.SerializeObject(material);  //Informacion de el material ingresado a serializar
        //        StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
        //        string responseString = mireader.ReadToEnd();
        //        //x_datos = JsonConvert.DeserializeObject(responseString, typeof(CRespuestaInt));

        //        //x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);
        //        x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);

        //        int respuesta_id_valor;
        //        string respuesta_error;

        //        if (x_datos.o_error.id != 0)
        //        {
        //            respuesta_id_valor = x_datos.valor;
        //            respuesta_error = x_datos.o_error.mensaje;
        //        }
        //        else
        //        {

        //        }

        //        //StringContent contentenido = new StringContent(x_material);

        //        o_error = x_datos.o_error;

        //    }
        //    catch (Exception e)
        //    {
        //        o_error = new CError();
        //        o_error.id = 100;
        //        o_error.mensaje = e.Message;
        //        return -1;
        //    }
        //    x_listar_materiales.cargar_grilla();
        //    return x_datos.valor;
        //}
        //// FIN INGRESAR \\



        //// MODIFICAR \\
        //public int ModificarMateriales(CMaterial material, ref CError o_error)
        //{
        //    o_error = new CError();

        //    ModificarMaterial x_modificar = new ModificarMaterial();

        //    string x_data = "{\"id\":" + material.id.ToString() +
        //       "," + "\"codigo\":\"" + material.codigo + "\"" +
        //       "," + "\"nombre\":\"" + material.nombre + "\"" +
        //       "," + "\"descripcion\":\"" + material.descripcion + "\"" +
        //       "," + "\"estado\":\"" + material.estado + "\"" +
        //       "," + "\"empresa\":\"" + material.empresa + "\"" +
        //       "," + "\"unidades\":\"" + material.unidades + "\"" +
        //       "," + "\"peso\":" + material.peso.ToString() +
        //       "," + "\"ancho\":" + material.ancho.ToString() +
        //       "," + "\"alto\":" + material.alto.ToString() +
        //       "," + "\"largo\":" + material.largo.ToString() +
        //       "," + "\"seriado\":\"" + material.seriado + "\"" +
        //       "," + "\"tipo_material\":" + material.tipo_material.ToString() +
        //       "}";

        //    byte[] dataStream = Encoding.UTF8.GetBytes(x_data);

        //    string url = get_url_rest() + "values/material/modificar";

        //    WebRequest request = WebRequest.Create(url);

        //    request.Method = "POST";
        //    request.ContentType = "application/json";
        //    request.ContentLength = dataStream.Length;

        //    Stream newStream = request.GetRequestStream();
        //    newStream.Write(dataStream, 0, dataStream.Length);

        //    WebResponse ws = request.GetResponse();

        //    CRespuestaInt x_datos = new CRespuestaInt();

        //    try
        //    {

        //        Stream mistream = ws.GetResponseStream();

        //        var x_material = JsonConvert.SerializeObject(material);  //Informacion de el material ingresado a serializar

        //        StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
        //        string responseString = mireader.ReadToEnd();

        //        x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);

        //        int respuesta_id_valor;
        //        string respuesta_error;

        //        if (x_datos.valor != 0 || x_datos.o_error.mensaje != "")
        //        {
        //            respuesta_id_valor = x_datos.valor;
        //            respuesta_error = x_datos.o_error.mensaje;
        //        }
        //        else
        //        {

        //        }

        //        StringContent contentenido = new StringContent(x_material);

        //        o_error = x_datos.o_error;

        //    }
        //    catch (Exception e)
        //    {
        //        o_error = new CError();
        //        o_error.id = 100;
        //        o_error.mensaje = e.Message;
        //        return -1;
        //    }


        //    return x_datos.valor;
        //}      

        //public int EliminarMaterial(CMaterial material, ref CError o_error)
        //{
        //    o_error = new CError();
        //    string url = get_url_rest() + "values/material/eliminar/" + material.id;
        //    WebRequest request = WebRequest.Create(url);
        //    request.Method = "DELETE";
        //    request.ContentType = "application/json";
        //    Stream newStream = request.GetRequestStream();
        //    WebResponse ws = request.GetResponse();
        //    CRespuestaInt x_datos = new CRespuestaInt();

        //    try
        //    {

        //        Stream mistream = ws.GetResponseStream();

        //        StreamReader mireader = new StreamReader(mistream, Encoding.UTF8);
        //        string responseString = mireader.ReadToEnd();

        //        x_datos = JsonConvert.DeserializeObject<CRespuestaInt>(responseString);


        //        o_error = x_datos.o_error;

        //    }
        //    catch (Exception e)
        //    {
        //        o_error = new CError();
        //        o_error.id = 100;
        //        o_error.mensaje = e.Message;
        //        return -1;
        //    }

        //    return x_datos.valor;
        //}


        #endregion

    }



}
