<template>
    <div class="d-flex justify-content-center align-items-center
vh-100">
  <div class="card p-4 shadow" style="max-width: 400px;
  width: 100%">
    <h3 class="text-center">Formulario de creación de
    países</h3>

    <div v-if="mensajeConfirmacion" class="alert alert-success text-center mt-3"> {{ mensajeConfirmacion }} </div>
    <form @submit.prevent="guardarPais">
      <div class="form-group">
        <label for="nombre">Nombre:</label>
        <input
        v-model="datosFormulario.nombre"
        type="text"
        id="name"
        class="form-control"
        required
        />
      </div>
      <div class="form-group">
        <label for="continente">Continente:</label>
        <select
          v-model="datosFormulario.continente"
          id="continente"
          required
          class="form-control"
        >
          <option value="" disabled>Seleccione un
          continente</option>
          <option>África</option>
          <option>Asia</option>
          <option>Europa</option>
          <option>América</option>
          <option>Oceanía</option>
          <option>Antártida</option>
        </select>
      </div>
      <div class="form-group">
      <label for="idioma">Idioma:</label>
      <input
        v-model="datosFormulario.idioma"
        type="text"
        id="idioma"
        class="form-control"
        required
      />
    </div>
      <div>
        <button type="submit" class="btn btn-success
        btn-block">
          Guardar
        </button>
      </div>
    </form>
  </div>
 </div>

  </template>
  
  <script>
    import axios from "axios";
    export default {
        data() {
            return {
                datosFormulario: {
                    nombre: "",
                    continente: "",
                    idioma: "",
                },
                mensajeConfirmacion: "",
            };
        },
        methods: {
            guardarPais() {
                console.log("Datos a guardar:", this.datosFormulario);
                axios
              .post("https://localhost:7265/api/Paises", {
                nombre: this.datosFormulario.nombre,
                continente: this.datosFormulario.continente,
                idioma: this.datosFormulario.idioma,
              })
              .then((response) => {
                console.log(response);
                this.mensajeConfirmacion = "El país fue agregado con éxito!";

                setTimeout(() => {
                  window.location.href = "/";
                }, 3000);
              })
              .catch(function (error) {
                console.log(error);
              });
            },
        },
    };
  </script>
  
  <style>
  
  </style>
  