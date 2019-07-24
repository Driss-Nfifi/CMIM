import React from 'react';
import PropTypes from 'prop-types';
import classNames from 'classnames';
import { withStyles } from '@material-ui/core/styles';
import MenuItem from '@material-ui/core/MenuItem';
import TextField from '@material-ui/core/TextField';
import Paper from '@material-ui/core/Paper';
import Grid from '@material-ui/core/Grid';
import Typography from '@material-ui/core/Typography';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import AddIcon from '@material-ui/icons/Add';
import IconButton from '@material-ui/core/IconButton';
import Tooltip from '@material-ui/core/Tooltip';
import Button from '@material-ui/core/Button';
import Modal from '@material-ui/core/Modal';
import axios from 'axios';
import LinearProgress from '@material-ui/core/LinearProgress';
import DeleteIcon from '@material-ui/icons/Delete';
import EditIcon from '@material-ui/icons/Edit';
import { Link, Switch, NavLink} from 'react-router-dom';
import Snackbar from '@material-ui/core/Snackbar';
import CloseIcon from '@material-ui/icons/Close';
import Chip from '@material-ui/core/Chip';
import moment from 'moment';
import Divider from '@material-ui/core/Divider';
import { isUndefined } from 'util';




const styles = theme => ({
  container: {
    display: 'flex',
    flexWrap: 'wrap',
  },
  textField: {
    marginLeft: theme.spacing.unit,
    marginRight: theme.spacing.unit,
  },
  dense: {
    marginTop: 16,
  },
  menu: {
    width: 200,
  },
  paper: {
    padding: theme.spacing.unit * 2,
    textAlign: 'center',
    color: theme.palette.text.secondary,
  },
  table: {
    minWidth: 700,
  },
  paper: {
    position: 'absolute',
    width: theme.spacing.unit * 50,
    backgroundColor: theme.palette.background.paper,
    boxShadow: theme.shadows[5],
    padding: theme.spacing.unit * 4,
  },
});
;

class DossierForm extends React.Component {
  state = {
    multiline: 'Controlled',
    open:false,
    referance:'',
    date: new Date(),
    datedossier : new Date(),
    datelunette : new Date(),
    montantTotal:'',
    MtCadre_L:0,
    MtGi_L:0,
    MtPharmacie_M:0,
    MtProthese_D:0,
    MtSoins_D:0,
    MtVisite_L:0,
    MtVisite_M:0,
    Mt_analyse:0,
    Mt_radio:0,
    Devis_D:0,


    avance:'',
    rembourse:'',
    diff:'',
    etat:'',
    employee:'',
    conjoint:'',
    add:false,
    update:false,
    isLoad:false,
    isClickable:true,
    open:true,
    message:'',
    selectedDate: new Date('2014-08-18T21:11:54'),
    
    employees:[],
    conjoints:[],
  };

/*verifDate = (datedossier) => {
    
    var dd = new Date(datedossier),
        month = '' + (dd.getMonth() + 1),
        day = '' + dd.getDate(),
        year = dd.getFullYear();
     
    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;
    if ( datedossier.getDate  < 80) {
      this.setState({
        open:true,
        message:"Ok"
     
      });
    }
    else { 
      this.setState({
      open:true,
      message:"NotOk"
     
      
  
      });
     }
    return [year, month, day].join('-');  
}*/

 formatDate = (date) => {
    var d = new Date(date),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;

    return [year, month, day].join('-');
}
  handleDateChange = date => {
      this.setState({ selectedDate: date });
 
    }
  handleChange = name => event => {
    if (name == "employee")
      this.getConjointByemp(event.target.value);
    this.setState({
      [name]: event.target.value,
    },() => {
      let sum = parseInt(parseInt(this.state.MtCadre_L || 0) + parseInt(this.state.MtGi_L || 0) + 
      parseInt(this.state.Mt_analyse || 0) + parseInt(this.state.Mt_radio || 0) + parseInt(this.state.MtPharmacie_M || 0)
      + parseInt(this.state.MtProthese_D || 0) + parseInt(this.state.MtSoins_D || 0)   + parseInt(this.state.MtVisite_L || 0)
      + parseInt(this.state.MtVisite_M || 0) + parseInt(this.state.Devis_D || 0)) ;
      this.setState({
        montantTotal:sum
      })
    });
  };
  handleOpen = () => {
    this.setState({ open: true });
  };

  handleClose = () => {
    this.setState({ open: false });
  };
  handleUpdateClick = () =>
  {
    this.setState({
      update:true
    })
  }
  handleDeleteClick = () =>
  {
    axios.delete('/api/Dossiers/'+this.state.referance)
      .then(res => {
        console.log(res);
        if(res.status == 200)
        {
          this.props.history.push("/dossiers");
        }
      })
  }
  handleCancelClick = () => {
    this.setState({
      update:false
    })

  }
handleSubmit = (e) => {
  this.setState({
    isLoad:true
  });
  let blacklist = [
    "safi",
    "kentira",
    "Act1",
    "Act2",
    "Act3",
    "Act4"
  ] 
  e.preventDefault();
  const data = {
    'referance': this.state.referance == '' ?  e.target.referance.value : this.state.referance ,
    'employeematricule':e.target.employee.value,
    'conjointmatricule':e.target.conjoint.value,
    
    'date':e.target.date.value,
    'datedossier':e.target.datedossier.value,

    'datelunette':e.target.datelunette.value,
    'montant':this.state.montantTotal,
    'MtGi_L':e.target.MtGi_L.value,
    'MtCadre_L':e.target.MtCadre_L.value,
    'MtVisite_L':e.target.MtVisite_L.value,
    
    'MtProthese_D':e.target.MtProthese_D.value,
    'MtSoins_D':e.target.MtSoins_D.value,
    'Devis_D':e.target.Devis_D.value,

    'MtVisite_M':e.target.MtVisite_M.value,
    'MtPharmacie_M':e.target.MtPharmacie_M.value,

    'Mt_analyse':e.target.Mt_analyse.value,
    'Mt_radio':e.target.Mt_radio.value,
    'avance':e.target.avance == undefined ? 0  : e.target.avance.value  ,
  };
  console.log(data);
  
  var diff = Math.abs( new Date(data.date) - new Date(data.datedossier));
  var days = moment.duration(diff).asDays();
  console.log(days);
  if(days > 80)
  {
    this.setState({
      open:true,
      message:"VeuiileZ enterer une date qui ne depasse 80 jours",
      isLoad:false,update:false,add:false,
  
    });
    return;
  }
  
  

  axios.get(`api/Employees/${data.employeematricule}`)
  .then(res => {
    console.log("Emp info: ");
    console.log(res.data);
    if(blacklist.indexOf(res.data.place.name ) > -1)
    {

      console.log("jjjjjjjjjjjjjjjjjjjjjjjjjjj");
      
      if((data.montantTotal * 0.8) > 2000){
        console.log("jjjjjjjjjjjjjbbbbbbb");
        
        this.setState({message:"Vous devez envoyer le dossier au siège de VIVO Energie pour être saisi",open:true,update:false,add:false,isLoad:false});
      }
      else
      {
        if(!this.state.update && this.state.add)
          {
            console.log("Post method handler");
            axios.get('/api/Dashboard/lastDateByEmp/'+data.employeematricule)
            .then(res => {
           
             
            var diff1 = Math.abs( new Date(data.datelunette) - new Date(res.data.dateLunette));
            var years = moment.duration(diff1).asYears();
            console.log(data.datelunette);
            console.log(res.data.dateLunette);
            console.log(diff1);
            
            console.log(years);
                  console.log(";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");
                if( years > 2 || data.datelunette == "" ){ 
                  
                  
                  
                  axios.post('/api/Dossiers',data)
                  .then(res => {
                    if (res.status == 201)
                    {
                        this.setState({
                          open:true,
                          message:"Ajouter avec succes",
                          referance:res.data.referance,
                          avance:(this.state.montantTotal * 0.8),
                          diff:(this.state.montantTotal - (this.state.montantTotal * 0.8)),
                        }); 
                    }
                    console.log(res);
                  });
                }else  {
                  this.setState({
                    open:true,
                    message:"La date des lunettes est invalide",
                  
                  }); 
              }
                return;
              
            })
          
          }
          else if (this.state.update && !this.state.add) {
            axios.put("/api/Dossiers/"+this.state.referance,data)
              .then(res => {
                if(res.status == 204)
                {
                    this.setState({
                      open:true,
                      message:"Modifier avec succes",
                      referance:res.data.referance,
                    
                      avance:this.state.avance,
                      diff:(this.state.montantTotal - (this.state.montantTotal * 0.8))
                    });
                
                    console.log(this.state.avance);
                }
                console.log(res);
              });
          }

            this.setState({
              isLoad:false,
              add:false,
              update:false
            });
      }
      
      
    }
    console.log();
    return; 
    
  })
  console.log(data);
  

  e.preventDefault();
  }
  getConjointByemp = (emp) => 
  {
    axios.get("/api/Conjoints/emp/" + emp)
    .then(res => {
      this.setState({
        conjoints:res.data
      })
    })
  }
   componentDidMount()
  {
    axios.get(`/api/employees`)
    .then(res => {
      this.setState({
        employees : res.data
      });
    });
    console.log(this.props.isAdd);
    if (this.props.isAdd == "true")
    {
      this.setState({
        isLoad:false
      });
      return;
    }

      this.setState({
        referance:this.props.match.params.ref
      });

    axios.get(`/api/Dossiers/${this.props.match.params.ref}`)
    .then(res => {
      if(res.status == 200)
      {
        console.log("sssssssssssssssssssssssssssssss");
        console.log(new Date(res.data.date));
        console.log(new Date(res.data.dateDossier));
        console.log(res);
        
        
        console.log(res.data.avance);
        this.setState({
          employee : res.data.employeematricule,
          conjoint : res.data.conjointmatricule,

          MtCadre_L:res.data.mtCadre_L,
          MtGi_L:res.data.mtGi_L,
          MtPharmacie_M:res.data.mtPharmacie_M,
          MtProthese_D:res.data.mtProthese_D,
          MtSoins_D:res.data.mtSoins_D,
          MtVisite_L:res.data.mtVisite_L,
          MtVisite_M:res.data.mtVisite_M,
          Mt_analyse:res.data.mt_analyse,
          Mt_radio:res.data.mt_radio,
          Devis_D:res.data.devis_D,
          montantTotal:res.data.montant,
          date:new Date(res.data.date),
          datedossier:moment(res.data.dateDossier).format("YYYY-MM-DD"),
          datelunette:moment(res.data.dateLunette).format("YYYY-MM-DD"),
          selectedDate:new Date(res.data.date),
          selectedDateDossier:new Date(res.data.dateDossier),
          selectedDateLunette : new Date(res.data.dateLunette),
          avance:res.data.avance,
          diff:res.data.diff,
          rembourse:res.data.rembourse,
          etat:res.data.etat
        });
      }
  });
    console.log(this.state);
    this.setState({
      isLoad:false
    })
  }

  constructor(props)
  {
     super(props);
     this.state = {
       date: new Date(),
      datedossier: new Date(),
      datelunette:new Date(),
       employees:[],
       conjoints:[],
       referance:props.isAdd == "true" ? '' : props.match.params.ref,
       etat:'ouvert',
       MtCadre_L:0,
       MtGi_L:0,
       MtPharmacie_M:0,
       MtProthese_D:0,
       MtSoins_D:0,
       MtVisite_L:0,
       MtVisite_M:0,
       Mt_analyse:0,
       Mt_radio:0,
       Devis_D:0,
       add:props.isAdd == "true" ? true : false,
       isLoad:props.isAdd == "true" ? false : true ,
       
     }
  }
  render() {
    const { classes } = this.props;

    return (

      <Grid container style={{width:"90%",margin:"0 auto"}}>

        <Grid item xs={12}  >
          <Paper>
          {this.state.isLoad && <LinearProgress color="primary" />}

          <form className={classes.container} Validate autoComplete="off" style={{textAlign:"center"}} onSubmit={this.handleSubmit} >

          <Grid container xs={6} >
              <Typography variant="h5" gutterBottom style={{padding:'20px'}} >
                {this.state.referance != '' ? this.state.referance : 'Nouveau dossier'}
                <Chip label={this.state.etat} style={{marginLeft:"10px"}} className={classes.chip}  color={(this.state.etat == "ouvert" ? "primary" : "secondary") } variant="outlined" />
              </Typography>
          </Grid>
          <Grid container xs={6} style={{justifyContent:'flex-end',padding:'18px'}}>
          {(this.state.add || this.state.update) &&
            <div>
            {!this.state.isLoad &&
              <Button variant="contained"   type="submit" color="primary" className={classes.button}>
                    sauvegarde
              </Button>
            }

              	&nbsp;	&nbsp;
              {!this.state.isLoad &&
                <Button className={classes.button} onClick={this.handleCancelClick}>
                      annuler
                </Button>
              }

            </div>

          }
          {(!this.state.add && !this.state.update) &&
            (
                <Tooltip title="Supprimer" aria-label="Supprimer">
                  <IconButton  className={classes.button} component="span" onClick={this.handleDeleteClick} >
                    <DeleteIcon/>
                  </IconButton>
                </Tooltip>

            )
          }
          {(!this.state.add && !this.state.update) &&
            (
                <Tooltip title="Modifier" aria-label="Modifier">
                  <IconButton className={classes.button} component="span" onClick={this.handleUpdateClick}>
                    <EditIcon/>
                  </IconButton>
                </Tooltip>
            )
          }
          </Grid>
        
         
            <Grid container  xs={12}  >
            {this.state.referance == '' &&
              <Grid item xs={4} style={{padding:"0 30px"}}>

                <TextField
                  id="referance"
                  label="Référence"
                  margin="normal"
                  className={classes.textField}

                  helperText="Obligatoire"
                  style={{marginBottom:"20px",width:"100%"}}
                  InputProps={{
                    readOnly: !(this.state.add || this.state.update),
                  }}
                />
              </Grid>
              }

             
              <Grid item xs={4} style={{padding:"0 30px"}}>
                  <TextField
                    id="employee"
                    select
                    label="Employé"
                    margin="normal"
                    className={classes.textField}
                    value={this.state.employee}
                    onChange={this.handleChange('employee')}
                    SelectProps={{
                      MenuProps: {
                        className: classes.menu,
                      },
                    }}
                    helperText="Obligatoire"
                    margin="normal"
                    style={{width:"200px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update)
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                    >
                    {this.state.employees.map(c => (
                     <MenuItem key={c.matricule} value={c.matricule}>
                                            {c.matricule + ' : ' + c.last_name + ' ' + c.first_name}
                      </MenuItem>) )
                    }
                   </TextField>
              </Grid>
              <Grid item xs={4} style={{padding:"0 30px"}}>
                  <TextField
                    id="conjoint"
                    select
                    label="Conjoint"
                    margin="normal"
                    className={classes.textField}
                    value={this.state.conjoint}
                    onChange={this.handleChange('conjoint')}
                    SelectProps={{
                      MenuProps: {
                        className: classes.menu,
                      },
                    }}
                    helperText="Obligatoire"
                    margin="normal"
                    style={{width:"200px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update)
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                    >
                    {this.state.conjoints.map(c => (
                     <MenuItem key={c.conjointId} value={c.conjointId}>
                                            {c.conjointId + ' : ' + c.lastname + ' ' + c.firstname}
                      </MenuItem>) )
                    }
                   </TextField>
              </Grid>
              <Grid item xs={4} style={{padding:"0 30px"}}>
                <TextField
                  id="date"
                  label="Date de création"
                  value={this.formatDate(this.state.date)}
                  type="date"
                  className={classes.textField}
                  onChange={this.handleChange('date')}
                  margin="normal"
                  helperText="Obligatoire"
                  style={{marginBottom:"20px",width:"100%"}}
                  InputProps={{
                    readOnly: !(this.state.add || this.state.update),
                  }}
                  InputLabelProps={{
                    shrink: true,
                  }}
                />
              </Grid>

              <Grid item xs={4} style={{padding:"0 30px"}}>
                <TextField
                  id="datedossier"
                  label="Date du dossier"
                  value={this.state.datedossier}
                  type="date"
                  className={classes.textField}
                  onChange={this.handleChange('datedossier')}
                  margin="normal"
                  helperText="Obligatoire"
                  style={{marginBottom:"80px",width:"100%"}}
                  InputProps={{
                    readOnly: !(this.state.add || this.state.update),
                  }}
                  InputLabelProps={{
                    shrink: true,
                  }}
                />
              </Grid>
              <Grid container  xs={12}  >
         
         
              <Grid  item xs={4} style={{padding:"0 30px"}} >
                <TextField
                  id="MtVisite_M"
                  label="Montant visite médicale"
                  value={this.state.MtVisite_M}
                  className={classes.textField}
                  onChange={this.handleChange('MtVisite_M')}
                  margin="normal"
                 
                  style={{marginBottom:"20px",width:"100%"}}
                  InputProps={{
                    readOnly: !(this.state.add || this.state.update),
                  }}
                  InputLabelProps={{
                    shrink: true,
                  }}
                />
              </Grid>
             
              
                <Grid  item xs={4} style={{padding:"0 30px"}} >
               
                  <TextField
                    id="MtPharmacie_M"
                    label="Montant Pharmacie"
                    value={this.state.MtPharmacie_M}
                    className={classes.textField}
                    onChange={this.handleChange('MtPharmacie_M')}
                    margin="normal"
                    
                    style={{marginBottom:"80px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update),
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                  />
                </Grid>
                
              </Grid>
              
              <Grid container  xs={12}  >
              <Divider light />
                <Grid  item xs={4} style={{padding:"0 30px"}} >
                  <TextField
                    id="MtSoins_D"
                    label="Montant Soins dentaire "
                    value={this.state.MtSoins_D}
                    className={classes.textField}
                    onChange={this.handleChange('MtSoins_D')}
                    margin="normal"
                  
                    style={{marginBottom:"20px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update),
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                  />
                </Grid>
             
            
                <Grid  item xs={4}   style={{padding:"0 30px"}} >
                  <TextField
                    id="MtProthese_D"
                    label="Montant prothèse dentaire "
                    value={this.state.MtProthese_D}
                    className={classes.textField}
                    onChange={this.handleChange('MtProthese_D')}
                    margin="normal"
                  
                    style={{marginBottom:"20px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update),
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                  />
                </Grid>
            
             
                <Grid  item xs={4} style={{padding:"0 30px"}} >
                  <TextField
                    id="Devis_D"
                    label="Devis"
                    value={this.state.Devis_D}
                    className={classes.textField}
                    onChange={this.handleChange('Devis_D')}
                    margin="normal"
                  
                    style={{marginBottom:"80px",marginLeft:"20px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update),
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                  />
                </Grid>
              </Grid>
              
              <Grid container  xs={12}  >
                <Grid  item xs={4} style={{padding:"0 30px"}} >
                  <TextField
                    id="Mt_radio"
                    label="Montant radiologie"
                    value={this.state.Mt_radio}
                    className={classes.textField}
                    onChange={this.handleChange('Mt_radio')}
                    margin="normal"
                  
                    style={{marginBottom:"80px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update),
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                  />
                </Grid>
              
                <Grid  item xs={4} style={{padding:"0 30px"}} >
                  <TextField
                    id="Mt_analyse"
                    label="Montant Analyse"
                    value={this.state.Mt_analyse}
                    className={classes.textField}
                    onChange={this.handleChange('Mt_analyse')}
                    margin="normal"
                  
                    style={{marginBottom:"20px",marginLeft:"20px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update),
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                  />
                </Grid>
              </Grid>
              <Grid container  xs={12}  >
                <Grid  item xs={4} style={{padding:"0 30px"}} >
                  <TextField
                    id="MtVisite_L"
                    label="Montant du visite Lunette"
                    value={this.state.MtVisite_L}
                    className={classes.textField}
                    onChange={this.handleChange('MtVisite_L')}
                    margin="normal"
                    
                    style={{marginBottom:"20px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update),
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                  />
                </Grid>
                <Grid  item xs={4} style={{padding:"0 30px"}} >
                  <TextField
                    id="MtCadre_L"
                    label="Montant cadre et verres"
                    value={this.state.MtCadre_L}
                    className={classes.textField}
                    onChange={this.handleChange('MtCadre_L')}
                    margin="normal"
                  
                    style={{marginBottom:"20px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update),
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                  />
                </Grid>
                <Grid  item xs={4} style={{padding:"0 30px"}} >
                  <TextField
                    id="MtGi_L"
                    label="Montant GI dépenses"
                    value={this.state.MtGi_L}
                    className={classes.textField}
                    onChange={this.handleChange('MtGi_L')}
                    margin="normal"
                  
                    style={{marginBottom:"80px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update),
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                  />
                </Grid>
                <Grid item xs={4} style={{padding:"0 30px"}}>
                <TextField
                  id="datelunette"
                  label="Date des lunettes"
                  value={this.state.datelunette}
                  type="date"
                  className={classes.textField}
                  onChange={this.handleChange('datelunette')}
                  margin="normal"
                 
                  style={{marginBottom:"80px",width:"100%"}}
                  InputProps={{
                    readOnly: !(this.state.add || this.state.update),
                  }}
                  InputLabelProps={{
                    shrink: true,
                  }}
                />
              </Grid>
              {this.state.referance != '' &&
                <Grid  item xs={4} style={{padding:"0 30px"}} >
                  <TextField
                    id="avance"
                    label="Avance"
                    value={this.state.avance}
                    className={classes.textField}
                    onChange={this.handleChange('avance')}
                    margin="normal"
                    helperText=""
                    style={{marginBottom:"20px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update),
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                  />
              </Grid>
              }

              {this.state.etat != "ouvert" &&
                  <Grid  item xs={4} style={{padding:"0 30px"}} >
                    <TextField
                      id="rembourse"
                      label="Rembourse"
                      value={this.state.rembourse}
                      className={classes.textField}
                      onChange={this.handleChange('rembourse')}
                      margin="normal"
                      helperText=""
                      style={{marginBottom:"20px",width:"100%"}}
                      InputProps={{
                        readOnly: !(this.state.add || this.state.update),
                      }}
                      InputLabelProps={{
                        shrink: true,
                      }}
                    />
                  </Grid>
              }
              {this.state.referance != '' &&
                  <Grid  item xs={4} style={{padding:"0 30px"}} >
                    <TextField
                      id="diff"
                      label="Différence"
                      value={this.state.diff}
                      className={classes.textField}
                      onChange={this.handleChange('diff')}
                      margin="normal"
                      helperText=""
                      style={{marginBottom:"20px",width:"100%"}}
                      InputProps={{
                        readOnly: !(this.state.add || this.state.update),
                      }}
                      InputLabelProps={{
                        shrink: true,
                      }}
                    />
                  </Grid>
              }
            </Grid>

            </Grid>
              <Grid container  xs={12}  >
                <Grid  item xs={4} style={{padding:"0 30px"}} >
                  <TextField
                    id="montantTotal"
                    label="Montant total"
                    value={this.state.montantTotal}
                    className={classes.textField}
                    onChange={this.handleChange('montantTotal')}
                    margin="normal"
                
                    style={{marginBottom:"20px",width:"100%"}}
                    InputProps={{
                      readOnly: !(this.state.add || this.state.update),
                    }}
                    InputLabelProps={{
                      shrink: true,
                    }}
                  />
                </Grid>
              </Grid>
            </form>
          </Paper>
        </Grid>
        <Snackbar
        anchorOrigin={{
          vertical: 'bottom',
          horizontal: 'left',
        }}
        open={this.state.open}
        autoHideDuration={60000}
        onClose={this.handleClose}
        ContentProps={{
          'aria-describedby': 'message-id',
        }}
        message={<span id="message-id">{this.state.message}</span>}
        action={[
          ,
          <IconButton
            key="close"
            aria-label="Close"
            color="inherit"
            className={classes.close}
            onClick={this.handleClose}
          >
            <CloseIcon />
          </IconButton>,
        ]}
      />
      </Grid>
    );
  }
}

DossierForm.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(DossierForm);
