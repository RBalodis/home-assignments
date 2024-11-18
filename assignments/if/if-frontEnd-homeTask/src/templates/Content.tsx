import React, { ReactNode } from 'react';
import { Outlet } from 'react-router-dom';
import styled from 'styled-components';
import classnames from 'classnames';

interface IfMainProps {
    children: ReactNode;
    className?: string;
}

const IfMain = ({ children, className }: IfMainProps) => {
    return <main className={classnames('if main', className)}>{children}</main>;
};
const Main = styled(IfMain)`
    &&& {
        background-color: #f6f3f0;
    }
`;

export const Content = ({ children }: { children?: ReactNode }) => {
    return (
        <Main>
            {children}
            <Outlet />
        </Main>
    );
};
