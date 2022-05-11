import React from "react";
import './questioncomponent.css'
import { faPlus } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

export default function QuestionComponent(props) {
    const Display = ()=>{
        document.getElementById(props.Question.Id).style.display === "none" ? document.getElementById(props.Question.Id).style.display = "" : document.getElementById(props.Question.Id).style.display = "none";
    }
    return (
        <div className="questionAccordion">
            <h2 className="headerAccordion" >
                <button className="buttonAccordion" onClick={Display}>
                    {props.Question.Title}<FontAwesomeIcon icon={faPlus} style={{ color: 'rgb(40, 44, 52)',fontSize:'25px' }} />
                </button>
            </h2>
            <div className="fdsf" id={props.Question.Id}>
                <div className="bodyAccordion">
                    {props.Question.Answer}
                    
                </div>
            </div>
        </div>
    );
}