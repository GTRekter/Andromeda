import React, { Component } from 'react';
import jQuery from 'jquery';
import './Skills.css';

export default class Skills extends Component {
    componentDidUpdate() {
        jQuery('.progress-bar').each(function () {
            var width = jQuery(this).data('progress');
            jQuery(this).find('.bar').animate({
                width: width + "%"
            }, 5000, "swing");
            jQuery(this).find('.text').animate({
                left: width + "%"
            },  {
                    duration: 5000,
                    easing: 'swing',
                    step: function (count) {
                        jQuery(this).text(Math.ceil(count));
                    }
                }
            );
        });
    }
    render() {
        let skillsEvidence = [];
        let skills = [];
        this.props.skills.forEach(function(skill, i) {
            if (skill.evidence) {
                skillsEvidence.push(<li key={i}>{skill.name}</li>);
            } else {
                skills.push(<div className="progress" key={i}>
                    <h3 className="progress-title">{skill.name}</h3>
                    <div className="progress-bar" data-progress={skill.proficency}>
                        <span className="bar" />
                        <span className="text">{skill.proficency}</span>
                    </div>
                </div>);
            }           
        });
        return (
            <div id="skills" className="cvitae-section cvitae-skills">
                <div className="cvitae-container">
                    <div className="cvitae-section-content">
                        <div className="content-left">
                            <h3 className="cvitae-section-title">Skills</h3>
                            {/*<p></p>*/}
                            <ul className="hi-lights">
                                {skillsEvidence}
                            </ul>
                        </div>
                        <div className="content-right">
                            <div className="progress-bar-container">
                                {skills}
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
