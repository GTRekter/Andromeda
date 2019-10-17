import React, { Component } from 'react';
import M from 'materialize-css/dist/js/materialize';
import './Education.css';

export default class Education extends Component {
    componentDidMount() {
        var elems = document.querySelectorAll('.collapsible');
        M.Collapsible.init(elems);
    }
    render() {
        let educations = [];
        this.props.educations.forEach(function (education, i) {
            let status;
            if (education.dateEnd === null) {
                if (education.dropped === false) {
                    status = "In progress";
                } else {
                    status = "Dropped";
                }
            } else {
                status = education.dateEnd;
            }
            educations.push(<li key={i}>
                <div className="collapsible-header">
                    <span className="name">{education.name}</span>, 
                    <span className="year">{status}</span>
                </div>
                <div className="collapsible-body">
                    <p>{education.description}</p>
                </div>
            </li>);
        });
        return (
            <div id="education" className="cvitae-section cvitae-education">
                <div className="cvitae-container">
                    <div className="cvitae-section-content">
                        <div className="content-left">
                            <h3 className="cvitae-section-title">Educaton</h3>
                            {/*<p></p>*/}
                        </div>
                        <div className="content-right">
                            <ul className="collapsible" data-collapsible="accordion">
                                {educations}
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
