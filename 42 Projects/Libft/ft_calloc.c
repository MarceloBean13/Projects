/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_calloc.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:25:55 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:26:50 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdlib.h>
#include "libft.h"

void	*ft_calloc(size_t count, size_t size)
{
	void *numbs;

	if (!(numbs = (char *)malloc(size * count)))
		return (NULL);
	return (ft_memset(numbs, 0, size * count));
}
