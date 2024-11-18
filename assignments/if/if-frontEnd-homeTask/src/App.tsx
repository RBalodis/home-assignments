import React from 'react';
import { BrowserRouter, Route, Routes } from 'react-router-dom';

import { Page } from './templates/Page';
import { Policies } from './templates/Policies';
import { Container } from './components/layout/Container';
import { Section } from './components/layout/Section';

function App() {
    return (
        <BrowserRouter>
            <Routes>
                <Route path="/" element={<Page />}>
                    <Route path="policies" element={<Policies />} />
                    <Route
                        path="*"
                        element={
                            <Section className={'darker'}>
                                <Container>
                                    <h1>Not found 🤷‍♂️</h1>
                                </Container>
                            </Section>
                        }
                    />
                </Route>
            </Routes>
        </BrowserRouter>
    );
}

export default App;
