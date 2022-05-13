import React from "react";
import './questioncomponent.css'
import { faPlus } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

export default function QuestionComponent(props) {
    const Display = () => {
        if (document.getElementById(props.Question.id).style.display === "none") {
            document.getElementById(props.Question.id).style.display = "";
            document.getElementById("icon" + props.Question.id).style.transform = "rotate(45deg)";
        }
        else {
            document.getElementById(props.Question.id).style.display = "none";
            document.getElementById("icon" + props.Question.id).style.transform = "rotate(0deg)";
        }
    }
    return (
        <div className="questionAccordion">
            <div className="headerAccordion" >
                <button className="buttonAccordion" onClick={Display}>
                    {props.Question.title}<FontAwesomeIcon id={"icon" + props.Question.id} icon={faPlus} />

                </button>
            </div>
            <div id={props.Question.id} style={{ display: 'none' }}>
                <div className="bodyAccordion">
                    {props.Question.answer}
                </div>
            </div>
        </div>
    );
}