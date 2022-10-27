
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using UltrAthleticsGenNHibernate.Exceptions;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;


/*PROTECTED REGION ID(usingUltrAthleticsGenNHibernate.CEN.UltrAthletics_Usuario_calcularMacronutrientes) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace UltrAthleticsGenNHibernate.CEN.UltrAthletics
{
public partial class UsuarioCEN
{
public void CalcularMacronutrientes (string p_oid)
{
        /*PROTECTED REGION ID(UltrAthleticsGenNHibernate.CEN.UltrAthletics_Usuario_calcularMacronutrientes) ENABLED START*/

        UsuarioCEN userCEN = new UsuarioCEN ();
        //obtengo el usuario pasado
        UsuarioEN userEN = userCEN.DameUsuarioOID (usuario_oid);

        //precondiciones
        if (peso <= 0) throw new Exception ("El peso no puede ser negativo o 0");
        if (altura <= 0) throw new Exception ("La altura no puede ser negativo o 0");
        if (edad <= 0) throw new Exception ("La edad no puede ser negativo o 0");
        if (userEN == null) throw new Exception ("El usuario con email: " + usuario_oid + " no existe");

        //asignar valor por estilo de vida para el calculo
        float valorEstiloVida = 1;
        switch (estilo) {
        case Enumerated.UltrAthletics.EstiloVidaEnum.sedentario: valorEstiloVida = 1.2f; break;

        case Enumerated.UltrAthletics.EstiloVidaEnum.ligero: valorEstiloVida = 1.37f; break;

        case Enumerated.UltrAthletics.EstiloVidaEnum.moderado: valorEstiloVida = 1.55f; break;

        case Enumerated.UltrAthletics.EstiloVidaEnum.fuerte: valorEstiloVida = 1.725f; break;

        case Enumerated.UltrAthletics.EstiloVidaEnum.extremo: valorEstiloVida = 1.9f; break;
        }

        //calculo del bmr
        int bmr = 0;
        if (sexo == Enumerated.UltrAthletics.SexoEnum.hombre) {
                bmr = (int)Math.Floor ((66.473f + (13.751f * peso) + (5.0033 * altura) - (6.55 * edad)) * valorEstiloVida);
        }
        else{
                bmr = (int)Math.Floor ((655.1 + (9.463f * peso) + (1.8f * altura) - (4.6756 * edad)) * valorEstiloVida);
        }

        //debug de la consola
        Console.WriteLine ("**********************");
        Console.WriteLine ("Pruebo el metodo calcularMacronutrientes");
        Console.WriteLine ("metabolismo basal: " + bmr);

        //ajustando calorias si quieres definir o ganar volumen
        if (objetivo == Enumerated.UltrAthletics.ObjetivosEnum.definicion) bmr -= 500;
        if (objetivo == Enumerated.UltrAthletics.ObjetivosEnum.volumen) bmr += 500;

        //calculando macros segun objetivo
        float grasas = 0;
        float hidratos = 0;
        float proteinas = 0;

        switch (objetivo) {
        case Enumerated.UltrAthletics.ObjetivosEnum.mantenimiento:
                hidratos = 0.45f * bmr;
                proteinas = 0.35f * bmr;
                grasas = 0.20f * bmr;
                break;

        case Enumerated.UltrAthletics.ObjetivosEnum.definicion:
                hidratos = 0.30f * bmr;
                proteinas = 0.40f * bmr;
                grasas = 0.30f * bmr;
                break;

        case Enumerated.UltrAthletics.ObjetivosEnum.volumen:
                hidratos = 0.50f * bmr;
                proteinas = 0.30f * bmr;
                grasas = 0.2f * bmr;
                break;
        }

        //calculamos en gramos los macros para que sea mas facil de entender al usuario
        hidratos /= 4;
        proteinas /= 4;
        grasas /= 9;
        float imc = altura / peso;

        userEN.Grasas = grasas;
        userEN.Hidratos = hidratos;
        userEN.Proteinas = proteinas;
        userEN.Objetivo = objetivo;
        userEN.Peso = peso;
        userEN.Altura = altura;
        userEN.Edad = edad;
        userEN.Estilo = estilo;
        userEN.Imc = imc;
        userEN.Calorias = bmr;

        Console.WriteLine ("calorias totales con el objetivo: " + bmr);
        Console.WriteLine ("proteina: " + proteinas);
        Console.WriteLine ("hidratos: " + hidratos);
        Console.WriteLine ("grasas: " + grasas);

        //postcondicion
        _IUsuarioCAD.ModifyDefault (userEN);

        return userEN;
        /*PROTECTED REGION END*/
}
}
}
