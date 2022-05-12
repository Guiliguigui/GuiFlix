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
            <div className="headerAccordion" >
                <button className="buttonAccordion" onClick={Display}>
                    {props.Question.Title}<FontAwesomeIcon icon={faPlus} />
                </button>
            </div>
            <div id={props.Question.Id} style={{display:'none'}}>
                <div className="bodyAccordion">
                    {props.Question.Answer}
                </div>
            </div>
        </div>
    );
}