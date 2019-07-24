import React, { useCallback } from 'react'
import { useDropzone } from 'react-dropzone'
import PropTypes from 'prop-types';
import * as XLSX from 'xlsx';
import axios from 'axios';
import CloudUpload from '@material-ui/icons/CloudUpload';

function Emplo() {
    const onDrop = useCallback(acceptedFiles => {
        const reader = new FileReader()

        reader.onabort = () => console.log('file reading was aborted')
        reader.onerror = () => console.log('file reading has failed')
        reader.onload = (evt) => {
            // Do whatever you want with the file contents

            const bstr = evt.target.result;
            const wb = XLSX.read(bstr, { type: 'binary' });
            /* Get first worksheet */
            const wsname = wb.SheetNames[0];
            const ws = wb.Sheets[wsname];
            /* Convert array of arrays */
            const data = XLSX.utils.sheet_to_csv(ws, { header: 1 });
            /* Update state */
            console.log(data);
            const data_arr = data.split("\n");
     

                        alert('telechargement fichier avec succes');
                        for (var i = 1; i < data_arr.length - 1; i++) {
                            const data_ar = data_arr[i].split(",");
                            console.log(data_ar);
                            const rembo2 = {
                                'matricule': data_ar[0],
                                'first_name': data_ar[1],
                                'last_name': data_ar[2],
                                'adresse': data_ar[3],
                                'company': data_ar[4],
                                'placeplacdeid': data_ar[5],
                            }

                            axios.post('/api/employees', rembo2)
                                .then(res => {
                                    console.log(res.  data);
                                    if (res.status == 201) {

                                    }
                                })
                        }

        }



        acceptedFiles.forEach(file => reader.readAsBinaryString(file))
    }, [])
    const { getRootProps, getInputProps, isDragActive } = useDropzone({ onDrop })

    return (
        <div {...getRootProps()} style={{ fontSize: "20px", textAlign: "center", border: "3px solid black", height: "80vh", borderStyle: "dashed", borderColor: "rgba(0, 0, 0, 0.54)" }}>
            <input {...getInputProps()} />
            <CloudUpload style={{ fontSize: "100px", color: "rgba(0, 0, 0, 0.54)", marginTop: "25vh"  }} />
            <p style={{  color:"rgba(0, 0, 0, 0.54)"  }}>Glissez ou selectionnez un fichier </p>
        </div>
    )
}

Emplo.propTypes = {
    classes: PropTypes.object.isRequired,
};

export default Emplo;
