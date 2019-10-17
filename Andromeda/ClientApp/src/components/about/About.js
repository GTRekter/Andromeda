import React, { Component } from 'react';
import About01 from '../../images/About-01.jpg';
import About02 from '../../files/Resume_EN.pdf';
import './About.css';

export default class About extends Component {
    render() {
        return (
            <div id="about" className="cvitae-section cvitae-about-me">
                <div className="cvitae-container">
                    <div className="cvitae-section-content">
                        <div className="content-left short-bio">
                            <div className="pic">
                                <img className="img-responsive" src={About01} alt={this.props.info.fullname} />
                            </div>
                            <p>Energetic and motivated software developer with experience in developing both web and client-based applications. Ivan is an ambitious developer who loves new technologies and finding ways to implement them in his projects to make his client’s lives easier. </p>
                        </div>
                        <div className="content-right about">
                            <h3 className="cvitae-section-title">About Me</h3>
                            <p className="info">
                                <span className="field-title">Full Name</span>
                                <span className="field-separator" />
                                <span className="field-value">{this.props.info.firstname} {this.props.info.lastname}</span>
                            </p>
                            <p className="info">
                                <span className="field-title">Address</span>
                                <span className="field-separator" />
                                <span className="field-value">{this.props.info.street}, {this.props.info.city}, {this.props.info.state}</span>
                            </p>
                            <p className="info">
                                <span className="field-title">Zip</span>
                                <span className="field-separator"/ >
                                <span className="field-value">{this.props.info.zip}</span>
                            </p>
                            <p className="info">
                                <span className="field-title">Phone</span>
                                <span className="field-separator" />
                                <span className="field-value">{this.props.info.mobile}</span>
                            </p>
                            <p className="info">
                                <span className="field-title">Email</span>
                                <span className="field-separator" />
                                <span className="field-value">{this.props.info.email}</span>
                            </p>
                        </div>
                        <div className="links">
                            <a href={About02} className="tooltipped" target="_blank" data-position="left" data-delay="50" data-tooltip="Download this Resume">
                                <i className="fa fa-save" aria-hidden="true" />
                                Download Resume
                            </a>
                            <a href={"mailto:" + this.props.info.email} className="tooltipped" target="_blank" data-position="left" data-delay="50" data-tooltip="Email this Resume">
                                <i className="fa fa-envelope-o" />
                                Email this Resume
                            </a>
                            <a href={this.props.info.github} className="tooltipped" target="_blank" data-position="left" data-delay="50" data-tooltip="Fork me on github">
                                <i className="fa fa-github-alt" aria-hidden="true" />
                                Github
                            </a>
                            <a href={this.props.info.linkedin} className="tooltipped" target="_blank" data-position="left" data-delay="50" data-tooltip="Follow on LinkedIn">
                                <i className="fa fa-linkedin" aria-hidden="true" />
                                LinkedIn Profile
                            </a>
                            <a href={this.props.info.twitter} className="tooltipped" target="_blank" data-position="left" data-delay="50" data-tooltip="Follow on Twitter">
                                <i className="fa fa-twitter" aria-hidden="true" />
                                Twitter Profile
                            </a>
                            <a href={this.props.info.facebook} className="tooltipped" target="_blank" data-position="left" data-delay="50" data-tooltip="Follow on Facebook">
                                <i className="fa fa-facebook" aria-hidden="true" />
                                Facebook Profile
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
