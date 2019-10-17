import React, { Component } from 'react';
import Contact01 from '../../images/Contact-01.png';
import Footer from '../footer/Footer';
import Swal from 'sweetalert2';
import './Contacts.css';

export default class Contacts extends Component {
    constructor(props) {
        super(props);
        this.state = {
            name: null,
            email: null,
            phone: null,
            website: null,
            message: null
        };
        this.onClickSubmit = this.onClickSubmit.bind(this);
    }
    onClickSubmit() {
        let ajaxData = {
            name: this.state.name,
            email: this.state.email,
            phone: this.state.phone,
            website: this.state.website,
            message: this.state.message
        };
        let requestOptions = {
            method: "POST",
            headers: {
                "content-type":"application/json"
            },
            body: JSON.stringify(ajaxData)
        };
        fetch('api/Email/SendEmail', requestOptions)
            .then(response => response.json())
            .then(data => {
                if (data.resultInfo === 1) {
                    Swal.fire('Oops...', 'Something went wrong!', 'error');
                } else {
                    Swal.fire('Success', 'Email sent', 'success');
                }
            });
    }
    render() {
        return (
            <div id="contact" className="cvitae-section cvitae-contact footer">
                <div className="cvitae-container">
                    <div className="cvitae-section-content">
                        <div className="content-left">
                            <h3 className="cvitae-section-title">Contact Me</h3>
                            <p>Please feel fee to leave a message to me. I would love to hear from you anytime.
                                Also you can call me or push me a message to my social networks. <br />
                                Thank you <br/>Regards -</p>
                            <img src={Contact01} alt="Signature" />
                        </div>
                        <div className="content-right">
                            <form method="post">
                                <div className="row">
                                    <div className="col s6">
                                        <div className="form-input">
                                            <input type="text" placeholder="your name*" defaultValue={this.state.name} />
                                            <span className="underline" />
                                        </div>
                                    </div>
                                    <div className="col s6">
                                        <div className="form-input">
                                            <input type="email" placeholder="email*" defaultValue={this.state.email} />
                                            <span className="underline" />
                                        </div>
                                    </div>
                                </div>
                                <div className="row">
                                    <div className="col s6">
                                        <div className="form-input">
                                            <input type="text" placeholder="phone*" defaultValue={this.state.phone} />
                                            <span className="underline" />
                                        </div>
                                    </div>
                                    <div className="col s6">
                                        <div className="form-input">
                                            <input type="text" placeholder="website" defaultValue={this.state.website}/>
                                            <span className="underline" />
                                        </div>
                                    </div>
                                </div>
                                <div className="row">
                                    <div className="col s12">
                                        <div className="form-textarea">
                                            <textarea placeholder="your message" defaultValue={this.state.website}/>
                                            <span className="underline"/>
                                        </div>
                                        <div className="form-submit">
                                            <button type="submit" className="waves-effect waves-cvitae" onClick={this.onClickSubmit}>Submit</button>
                                            <span className="underline"/>
                                        </div>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
                <Footer info={this.props.info} />
            </div>
        );
    }
}