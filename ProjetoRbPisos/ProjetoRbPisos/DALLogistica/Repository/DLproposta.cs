using DALLogistica.Entities;
using DALLogistica.NHibertnate;
using DALLogistica.NHibertnate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DALLogistica.Repository
{
    public class DLproposta : Repository<proposta>
    {
        public List<PropostaViewModel> ListarPropostaStatus()
        {
            try
            {
                var lstProposta = new List<PropostaViewModel>();
                var listaProposta = new DLproposta().Listar();
                var listaStatus = new DLstatusobra().Listar();

                var resultado = listaProposta
                   .Join(listaStatus, proposta => proposta.statusobraid, statuss => statuss.StatusObraId, (proposta, stattuss) => new { proposta, stattuss })
                   .Select(x => new PropostaViewModel()
                   {
                       propostaid = x.proposta.propostaid,
                       dataprevista = x.proposta.dataprevista,
                       datapedido = x.proposta.datapedido,
                       fabrica = x.proposta.fabrica,
                       faturado = x.proposta.faturado,
                       formapag = x.proposta.formapag,
                       engresp = x.proposta.engresp,
                       telefone = x.proposta.telefone,
                       pdrb = x.proposta.pdrb,
                       pdvenda = x.proposta.pdvenda,
                       propostaa = x.proposta.propostaa,
                       construtora = x.proposta.construtora,
                       colocador = x.proposta.colocador,
                       aprovadosergio = x.proposta.aprovadosergio,
                       obra = x.proposta.obra,
                       comentario = x.proposta.comentario,
                       dataentrega = x.proposta.dataentrega,
                       Status = x.stattuss.Descricao,
                       material = x.proposta.material,
                       recebidopor = x.proposta.recebidopor,
                       notafiscal = x.proposta.notafiscal,
                       carreto = x.proposta.carreto,
                     
                     

                   }).ToList();


                foreach (var proposta in resultado)
                {
                    #region codigo antigo
                    //var prop = new PropostaViewModel();

                    //prop.propostaid = proposta.propostaid;
                    //prop.dataprevista = proposta.dataprevista;
                    //prop.datapedido = proposta.datapedido;
                    //prop.fabrica = proposta.fabrica;
                    //prop.faturado = proposta.faturado;
                    //prop.formapag = proposta.formapag;
                    //prop.engresp = proposta.engresp;
                    //prop.telefone = proposta.telefone;
                    //prop.pdrb = proposta.pdrb;
                    //prop.pdvenda = proposta.pdvenda;
                    //prop.propostaa = proposta.propostaa;
                    //prop.construtora = proposta.construtora;
                    //prop.obra = proposta.obra;
                    //prop.loft = proposta.loft;
                    //prop.outros = proposta.outros;
                    //prop.comentario = proposta.comentario;
                    //prop.dataentrega = proposta.dataentrega;
                    //prop.recebidopor = proposta.recebidopor;
                    //prop.notafiscal = proposta.notafiscal;
                    //prop.material = proposta.material;
                    //prop.carreto = proposta.carreto;
                    //prop.aprovadosergio = proposta.aprovadosergio;
                    //prop.colocador = proposta.colocador;

                    //prop.Status = proposta.Descricao;
                    #endregion

                    switch (proposta.Status)
                    {
                        case "Imediato":
                            proposta.OrdenacaoStatus = 1;
                            break;

                        case "Pendente":
                            proposta.OrdenacaoStatus = 2;
                            break;

                        case "Finalizado":
                            proposta.OrdenacaoStatus = 3;
                            break;

                        case "Cancelado":
                            proposta.OrdenacaoStatus = 4;
                            break;

                    }

                    proposta.ItensProposta = new DLitensproposta().Listar().Where(x => x.propostaid == proposta.propostaid).ToList();

                    lstProposta.Add(proposta);
                }


                return lstProposta.OrderByDescending(p => p.Status).ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public List<PropostaViewModel> ListarPropostaStatus(string material)
        {
            try
            {
                var itens = new DLitensproposta().Listar().Where(x => x.material.ToLower().Contains(material.ToLower())).Select(x => x.propostaid).ToList();
                var lstProposta = new List<PropostaViewModel>();
                var listaProposta = new DLproposta().Listar();
                var listaStatus = new DLstatusobra().Listar();
                var resultado = listaProposta
                   .Join(listaStatus, proposta => proposta.statusobraid, statuss => statuss.StatusObraId, (proposta, stattuss) => new { proposta, stattuss })
                   .Select(x => new PropostaViewModel()
                   {
                       propostaid = x.proposta.propostaid,
                       dataprevista = x.proposta.dataprevista,
                       datapedido = x.proposta.datapedido,
                       fabrica = x.proposta.fabrica,
                       faturado = x.proposta.faturado,
                       formapag = x.proposta.formapag,
                       engresp = x.proposta.engresp,
                       telefone = x.proposta.telefone,
                       pdrb = x.proposta.pdrb,
                       pdvenda = x.proposta.pdvenda,
                       propostaa = x.proposta.propostaa,
                       construtora = x.proposta.construtora,
                       colocador = x.proposta.colocador,
                       aprovadosergio = x.proposta.aprovadosergio,
                       obra = x.proposta.obra,
                       comentario = x.proposta.comentario,
                       dataentrega = x.proposta.dataentrega,
                       Status = x.stattuss.Descricao,
                       material = x.proposta.material,
                       recebidopor = x.proposta.recebidopor,
                       notafiscal = x.proposta.notafiscal,
                       carreto = x.proposta.carreto,
                      
                   }).ToList().Where(x => itens.Contains(x.propostaid));
                foreach (var proposta in resultado)
                {
                    switch (proposta.Status)
                    {
                        case "Imediato":
                            proposta.OrdenacaoStatus = 1;
                            break;
                        case "Pendente":
                            proposta.OrdenacaoStatus = 2;
                            break;
                        case "Finalizado":
                            proposta.OrdenacaoStatus = 3;
                            break;
                        case "Cancelado":
                            proposta.OrdenacaoStatus = 4;
                            break;
                    }
                    lstProposta.Add(proposta);
                }
                return lstProposta.OrderByDescending(p => p.Status).ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
    public class PropostaViewModel
    {
        public PropostaViewModel()
        {
            ItensProposta = new List<itensproposta>();
        }
        public virtual int propostaid { get; set; }
        public virtual DateTime dataprevista { get; set; }
        public virtual DateTime datapedido { get; set; }
        public virtual string fabrica { get; set; }
        public virtual string faturado { get; set; }
        public virtual string aprovadosergio { get; set; }
        public virtual string colocador { get; set; }
        public virtual string material { get; set; }
        public virtual string formapag { get; set; }
        public virtual string engresp { get; set; }
        public virtual string telefone { get; set; }
        public virtual string pdrb { get; set; }
        public virtual string pdvenda { get; set; }
        public virtual string propostaa { get; set; }
        public virtual string construtora { get; set; }
        public virtual string obra { get; set; }
        public virtual string comentario { get; set; }
        public virtual DateTime dataentrega { get; set; }
        public virtual string recebidopor { get; set; }
        public virtual string notafiscal { get; set; }
        public virtual string carreto { get; set; }
        public virtual int statusobraid { get; set; }
    
        public int OrdenacaoStatus { get; set; }
        public string Status { get; set; }

        public List<itensproposta> ItensProposta { get; set; }

    }

}
