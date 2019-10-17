import React, { Component } from 'react';
import M from 'materialize-css/dist/js/materialize';
import './Experience.css';

export default class Experience extends Component {
    constructor(props) {
        super(props);
        this.state = {
            viewAll: false,
            viewAllText: "View all"
        };
    }
    componentDidMount() {
        var elems = document.querySelectorAll('.collapsible');
        M.Collapsible.init(elems);
        this.onClickViewAll = this.onClickViewAll.bind(this);
    }
    onClickViewAll() {
        if (this.state.viewAll) {
            this.setState({
                viewAll: false,
                viewAllText: "View all"
            });
        } else {
            this.setState({
                viewAll: true,
                viewAllText: "Hide old"
            });
        }      
    }
    render() {
        let experiences = []; 
        let viewAll = this.state.viewAll;
        this.props.experiences.forEach(function (experience, i) {
            if (!viewAll && i >= 4) {
                return false;
            }
            experiences.push(<li key={i}>
                <div className="collapsible-header">
                    <span className="company">{experience.company}</span>
                    <span className="degree">as</span>
                    {experience.name}, 
                    <span className="year">{experience.dateStart} - {experience.dateEnd === null ? "Current" : experience.dateEnd}</span>
                </div>
                <div className="collapsible-body">
                    <p>{experience.description}</p>
                    <p className="details">
                        <span className="title">Address</span>{experience.street}, {experience.zip}, {experience.city}, {experience.country}
                    </p>
                    <p className="details">
                        <span className="title">Website</span>{experience.website}
                    </p>
                </div>
            </li>);        
        });    
        return (
            <div id="experience" className="cvitae-section cvitae-experience">
                <div className="cvitae-container">
                    <div className="cvitae-section-content">
                        <div className="content-left">
                            <h3 className="cvitae-section-title">Experience</h3>
                            {/*<p></p>*/}
                            <a className="view-all" onClick={this.onClickViewAll}>{this.state.viewAllText}</a>
                        </div>
                        <div className="content-right">
                            <ul className="collapsible" data-collapsible="accordion">
                                {experiences}
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
