import React from "react";
import './mediadetailscomponent.css';

export default function MediaDetailsComponent(props) {
    const close=()=>{
        props.setIsDetails(false);
    }
    return (
    <div className="mediaDetails">
        <h1>it works</h1>
        <button onClick={close}>close</button>
        {console.log("it works")}
    </div>
    )
}