import React, { ReactNode } from 'react';

export interface ContainerProps {
    children: ReactNode;
}

export const Container = ({ children }: ContainerProps) => {
    return <div className="if container">{children}</div>;
};
