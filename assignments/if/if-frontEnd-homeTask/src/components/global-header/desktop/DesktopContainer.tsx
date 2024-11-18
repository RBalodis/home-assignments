import React, { HTMLAttributes, ReactNode } from 'react';
import classnames from 'classnames';

export interface DesktopContainerProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLDivElement>['className'];
}

export const DesktopContainer = ({
    children,
    className,
}: DesktopContainerProps) => {
    return (
        <div className={classnames('if desktop container', className)}>
            {children}
        </div>
    );
};
